using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon.API;
using Codeathon.API.Utilities;
using Codeathon.API.Interfaces;
using Codeathon.API.Services;
using Codeathon.DataModel;
using System.Data.Entity;

namespace Codeathon.API.Services
{
    public enum UserRole
    {
        Admin,
        General
    }
    public class RoleService : LogicCRUD<int, Role>
    {

        public RoleService()
        {
            Read().ToList().ForEach((role) =>
            {
                System.Diagnostics.Debug.WriteLine(role.Name);
            });
            //Init default roles
            string[] roleString = Enum.GetNames(typeof(UserRole));
            for(int i = 0; i < roleString.Length; i++)
            {
                Role r = Read((role) => role.Name == roleString[i]).FirstOrDefault();
                if (r == null)
                {
                    Create(new Role()
                    {
                        Name = roleString[i]
                    });
                    SaveChanges();
                }
            }
            
        }

        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<Role> GetDbSet()
        {

            return Service<CodeathonContainer>.Use().Roles;
        }

        protected override int GetKey(Role entity)
        {
            return entity.Id;
        }

        public Role GetRole(UserRole userRole)
        {

            Role r = Read((role) => role.Name == userRole.ToString()).FirstOrDefault();
            
            return r;
        }

    }
}
