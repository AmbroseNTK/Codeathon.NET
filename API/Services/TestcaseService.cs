using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon.API.Utilities;
using Codeathon.API.Services;
using Codeathon.DataModel;

namespace Codeathon.API.Services
{
    public class TestcaseService : SimpleCRUD<int, TestCase>
    {
        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<TestCase> GetDbSet()
        {
            return Service<CodeathonContainer>.Use().TestCases;
        }

        protected override int GetKey(TestCase entity)
        {
            return entity.Id;
        }
    }
}
