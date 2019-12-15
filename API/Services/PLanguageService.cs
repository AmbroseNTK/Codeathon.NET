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
        public string[] languages =
        {
            "Python","Ruby","Clojure","PHP","Javascript",
            "Scala","Go","C/C++","Java","VB.NET",
            "C#","Bash","Objective-C","MySQL","Perl",
            "Rust","Pascal"
        };

        public PLanguageService()
        {
            foreach(string language in languages)
            {
                if(Read((lang)=>lang.Name == language).ToList().FirstOrDefault() == null)
                {
                    Create(new PLanguage()
                    {
                        Name = language,
                        Version = "1"
                    });
                }
            }
            SaveChanges();
        }

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
