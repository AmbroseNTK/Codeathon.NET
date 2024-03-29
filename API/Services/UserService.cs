﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using Codeathon.API.Utilities;
using Codeathon.DataModel;
using Codeathon.API.Events;

namespace Codeathon.API.Services
{
    public class UserService : LogicCRUD<long, DataModel.User>
    {

        public UserService()
        {
            if (GetUserByUsername("admin") == null)
            {
                GetDbSet().Add(new User()
                {
                    Role = Service<RoleService>.Use().GetRole(UserRole.Admin),
                    Email = "admin",
                    HashPassword = "admin".Hasing(),
                    Profile = new Profile()
                    {
                        Username = "admin",
                        PhoneNumber = "012 345 678",
                        Avatar = ""
                    }
                });
                SaveChanges();
            }
        }

        public event LoginSuccessHandler OnLoginSuccess;
        public event RegisterSuccessHandler OnRegisterSuccess;

        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<User> GetDbSet()
        {
            return Service<CodeathonContainer>.Use().Users;
        }

        protected override long GetKey(User entity)
        {
            return entity.UID;
        }

        /// <summary>
        /// Create new user if it doesn't exist in the system
        /// </summary>
        /// <param name="entity">New user</param>
        /// <param name="retypedPassword">Retyped password</param>
        /// <param name="profile">User's profile</param>
        public void Register(string email, string password, string retypedPassword, Profile profile)
        {

            if (password != retypedPassword)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = "Password and Retyped-password is not match"
                });
                return;
            }

            if (Read((usr)=>usr.Profile.Username == profile.Username).Count()!=0)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = "Username " + profile.Username + " already existed"
                }) ;
                return;
            }

            User duplication = Read((usr) => usr.Email == email).FirstOrDefault();

            if (duplication != null)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = email + " is already existed"
                });
                return;
            }
            try
            {
                User user = new User()
                {
                    Email = email,
                    HashPassword = password.Trim().Hasing(),
                    Profile = profile,
                    Role = Service<RoleService>.Use().GetRole(UserRole.General)
            };
                Create(user);
                
                SaveChanges();
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Register successfully"
                });
                OnRegisterSuccess?.Invoke();
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
                Service<AuthData>.Use().Set(user);
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Login successfully"
                });
                OnLoginSuccess?.Invoke();
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

        public User GetUserByUsername(string username)
        {
            return Read((usr) => usr.Profile.Username == username).FirstOrDefault();
        }

    }
}
