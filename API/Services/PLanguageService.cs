using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon.DataModel;
using Codeathon.API.Utilities;
using System.Data.Entity;

namespace Codeathon.API.Services
{
    public class PLanguageService : SimpleCRUD<long, PLanguage>
    {
        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<PLanguage> GetDbSet()
        {
            return Service<CodeathonContainer>.Use().PLanguages;
        }

        protected override long GetKey(PLanguage entity)
        {
            return entity.Id;
        }
    }
}
