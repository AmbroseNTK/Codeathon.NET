using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon.API.Services;
using Codeathon.API.Utilities;
using Codeathon.DataModel;

namespace Codeathon.API.Services
{
    class SolutionService : LogicCRUD<long, Solution>
    {
        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<Solution> GetDbSet()
        {
            return Service<CodeathonContainer>.Use().Solutions;
        }

        protected override long GetKey(Solution entity)
        {
            return entity.Id;
        }

        public void SubmitSolution(Solution solution)
        {
            Solution previousSolution = Read((sol) => sol.User.Email == solution.User.Email 
            && sol.PLanguage.Id == solution.PLanguage.Id).ToList().FirstOrDefault();

            if (previousSolution != null)
            {
                solution.Id = previousSolution.Id;
                Update(previousSolution.Id, solution);
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Re-submit successfully"
                });
            }
            else
            {
                Create(solution);
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Submit successfully"
                });
            }
            SaveChanges();
        }

    }
}
