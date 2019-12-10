using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon;
using Codeathon.API;
using Codeathon.API.Services;
using Codeathon.API.Utilities;
using Codeathon.DataModel;

namespace Codeathon.API.Services
{
    public class ChallengeService : LogicCRUD<long, Challenge>
    {
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
        public void Create(string name,string title, string shortDescription, string description, Category category,List<TestCase> testcases, bool isPublic = true)
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
                TestCases = testcases
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
        public void Update(Category category)
        {
            try
            {
                Update(category);
                SaveChanges();
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
    }
}
