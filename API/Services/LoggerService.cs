using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon.DataModel;
using Codeathon.API.Utilities;
using Codeathon.API.Interfaces;
using System.Data.Entity;

namespace Codeathon.API.Services
{
    public class LoggerService : SimpleCRUD<long, SystemLog>
    {
        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<SystemLog> GetDbSet()
        { 
            SystemLog log = new Log();
            
            return Service<CodeathonContainer>.Use().SystemLogs;
        }

        protected override long GetKey(SystemLog entity)
        {
            return entity.Id;
        }
    }
}
