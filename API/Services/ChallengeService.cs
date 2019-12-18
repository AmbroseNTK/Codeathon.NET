using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon;
using Codeathon.API;
using Codeathon.API.Events;
using Codeathon.API.Services;
using Codeathon.API.Utilities;
using Codeathon.DataModel;

using RestSharp;

namespace Codeathon.API.Services
{
    public class ChallengeService : LogicCRUD<long, Challenge>
    {
        public event TestCaseRunSuccessHandler OnTestRunSuccess;
        public event TestCaseRunFailedHandler OnTestRunFailed;

        public class SubmitResult
        {
            public string output { get; set; }
            public string errors { get; set; }
            public string time { get; set; }

        }
        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<Challenge> GetDbSet()
        {
            return Service<CodeathonContainer>.Use().Challenges;
        }

        protected override long GetKey(Challenge entity)
        {
            return entity.Id;
        }
        public List<Challenge> GetPublic()
        {
            try
            {
                return Read((challenge) => challenge.IsPublic).ToList();
            }
            catch (Exception ex)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = ex.Message
                });
                return new List<Challenge>();
            }
        }
        public List<Challenge> GetOwnChallenges()
        {
            return Service<AuthData>.Use().Get().Challenges.ToList();
        }
        public List<Challenge> GetPublicChallenges()
        {
            return Read((challenge) => challenge.IsPublic).ToList();
        }
        public void CreateNew(Challenge newChallenge)
        {
            Challenge duplication = Read((challenge) => challenge.Name == newChallenge.Name).FirstOrDefault();
            if (duplication != null)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = newChallenge.Name + " already existed"
                });
                return;
            }
           
            try
            {
                Create(newChallenge);
                SaveChanges();
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Create " + newChallenge.Name + " successfully"
                });
                return;
            }
            catch (Exception ex)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = ex.Message
                });
                return;
            }
        }
        public void Create(string name,string title, string shortDescription, string description, Category category, List<TestCase> testcases, bool isPublic = true)
        {
            Challenge duplication = Read((challenge) => challenge.Name == name).FirstOrDefault();
            if(duplication != null)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = name + " already existed"
                });
                return;
            }
            // Assigning
            Challenge newChallenge = new Challenge()
            {
                Name = name,
                Title = title,
                ShortDescription = shortDescription,
                Description = description,
                Category = category,
                Owner = Service<AuthData>.Use().Get(),
                IsPublic = isPublic,
                TestCases = testcases,
                LastUpdate = DateTime.Now
            };
            try
            {
                Create(newChallenge);
                SaveChanges();
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Create "+ name + " successfully"
                });
                return;
            }
            catch (Exception ex)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = ex.Message
                });
                return;
            }
        }
        public void Update(Challenge challenge)
        {
            challenge.LastUpdate = DateTime.Now;
            try
            {
                Update(challenge.Id,challenge);
                SaveChanges();
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Update successfully"
                });
            }
            catch (Exception ex)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = ex.Message
                });
                return;
            }
        }
        public void Remove(long key)
        {
            Challenge deletion = Read((challenge) => challenge.Id == key).FirstOrDefault();
            if(deletion == null)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = key + " did not exist"
                });
                return;
            }

            if(deletion.Owner.UID != Service<AuthData>.Use().Get().UID)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = "Permission denied"
                });
                return;
            }

            try
            {
                Delete(key);
                SaveChanges();
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = key + " was deleted"
                });
                return;
            }
            catch(Exception ex)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = ex.Message
                });
                return;
            }
        }

        public void SubmitSolution(Challenge challenge, int languageCode, string code, TestCaseRunSuccessHandler onSuccess =null, TestCaseRunFailedHandler onFailed = null)
        {
            var client = new RestClient("https://pm.itsstraining.edu.vn:8889");
            List<TestCase> testcases = challenge.TestCases.ToList();
            double totalTime = 0;
            foreach(TestCase testcase in testcases)
            {
                var request = new RestRequest("compile", Method.POST);
                request.AddParameter("language", languageCode.ToString());
                request.AddParameter("code", code);
                request.AddParameter("stdin", testcase.Input);
                var response = client.Execute<SubmitResult>(request);
                if (response.Data.errors !="")
                {
                    onFailed?.Invoke(response.Data.errors);
                    return;
                }
                if (response.Data.output.Trim() == testcase.ExpectedOutput)
                {
                    totalTime += double.Parse(response.Data.time.Trim());
                }
                else
                {
                    if (testcase.AllowView)
                    {
                        onFailed?.Invoke("Your result: " + response.Data.output + "\nExpected: " + testcase.ExpectedOutput);
                    }
                    else
                    {
                        onFailed?.Invoke("Test failed");
                    }
                    return;
                }
            }
            try
            {
                Service<SolutionService>.Use().SubmitSolution(challenge, new Solution()
                {
                    User = Service<AuthData>.Use().Get(),
                    Datetime = DateTime.Now,
                    Challenge = challenge,
                    PLanguage = Service<PLanguageService>.Use().Read((lang) => lang.Id == (languageCode+1)).FirstOrDefault(),
                    ExecuteTime = totalTime.ToString(),
                    SourceCode = code
                });
                onSuccess?.Invoke(totalTime);
            }
            catch (Exception ex)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = ex.Message
                });
            }
            
        }

    }
}
