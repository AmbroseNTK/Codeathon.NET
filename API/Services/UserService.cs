using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using Codeathon.API.Utilities;
using Codeathon.DataModel;

namespace Codeathon.API.Services
{
    public class UserService : LogicCRUD<Guid, DataModel.User>
    {
        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<User> GetDbSet()
        {
            return Service<CodeathonContainer>.Use().Users;
        }

        protected override Guid GetKey(User entity)
        {
            return entity.UID;
        }
        /// <summary>
        /// Create new user if it doesn't exist in the system
        /// </summary>
        /// <param name="entity">New user</param>
        /// <param name="retypedPassword">Retyped password</param>
        public void Register(string email, string password, string retypedPassword)
        {
           
            if (password == retypedPassword)
            {
                User duplication = Service<CodeathonContainer>.Use().Users
                      .ToList().Where((usr) => usr.Email == email).FirstOrDefault();
                if (duplication == null)
                {
                    try
                    {
                        Create(new User()
                        {
                            Email = email,
                            HashPassword = password.Trim().Hasing()
                        });
                        SaveChanges();
                        Service<Notificator>.Use().Push(new Notification()
                        {
                            Status = NotificationStatus.Info,
                            Info = "Register successfully"
                        });
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
                else
                {
                    Service<Notificator>.Use().Push(new Notification()
                    {
                        Status = NotificationStatus.Error,
                        Info = email + " is already existed"
                    });
                }
            }
            else
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = "Password and Retyped-password is not match"
                });
            }
        }

        /// <summary>
        /// Login with email and password. The result will stored in Auth Data
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void Login(string email, string password)
        {
            User user = Read((usr) => usr.Email == email && usr.HashPassword == password.Trim().Hasing()).FirstOrDefault();
            if (user != null)
            {
                Service<AuthData>.Use().Set(user.UID, email);
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Login successfully"
                });
            }
            else
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = "Email or Password is invalid"
                });
            }
        }

    }
}
