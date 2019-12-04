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
    public class LoggerService : SimpleCRUD<long, Log>
    {
        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<Log> GetDbSet()
        {
            return Service<CodeathonContainer>.Use().Logs;
        }

        protected override long GetKey(Log entity)
        {
            return entity.Id;
        }
    }
}
