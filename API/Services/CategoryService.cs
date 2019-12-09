using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon;
using Codeathon.API.Services;
using Codeathon.API.Utilities;
using Codeathon.DataModel;

namespace Codeathon.API.Services
{
    public class CategoryService : LogicCRUD<int, Category>
    {
        public CategoryService()
        {
            if (GetDbSet().ToList().Where((cat) => cat.Name == "General").FirstOrDefault() == null)
            {
                Create(new Category() {
                    Name = "General",
                    Description = "General things in programming",
                    User = Service<UserService>.Use().GetUserByUsername("admin"),
                    CoverImage = "000"
                });
            }
        }

        protected override DbContext GetContext()
        {
            return Service<CodeathonContainer>.Use();
        }

        protected override DbSet<Category> GetDbSet()
        {
            return Service<CodeathonContainer>.Use().Categories;
        }

        protected override int GetKey(Category entity)
        {
            return entity.Id;
        }

        public void Add(Category category)
        {
            //Check Name duplication
            Category result = GetDbSet().ToList().Where((cat) => cat.Name == category.Name).FirstOrDefault();
            if (result != null)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = "This category already existed"
                });
                return;
            }

            //Assign owner to new category
            category.User = Service<UserService>.Use().GetUserByUsername(Service<AuthData>.Use().Get().Profile.Username);
            try
            {
                Create(category);
                SaveChanges();
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Create succefully"
                });
            }
            catch(Exception e)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = e.Message
                });
                return;
            }
            return;
        }

        public List<Category> GetOwnCategory()
        {
            return Service<AuthData>.Use().Get().Categories.ToList();
        }

        public void Delete(Category category)
        {
            if (category.Challenges.Count != 0)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = "This category is not empty"
                });
                return;
            }

            if (!Service<AuthData>.Use().Get().Categories.Contains(category))
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
                Delete(category.Id);
                SaveChanges();
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Delete succefully"
                });
            }
            catch(Exception ex)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = ex.Message
                });
            }
        }
        public Category GetCategoryById(int id)
        {
            return Read((category) => category.Id == id).FirstOrDefault();
        }

        public void Update(Category category)
        {
            try
            {
                Update(category.Id, category);
                SaveChanges();
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Info,
                    Info = "Update succefully"
                });
            }
            catch(Exception ex)
            {
                Service<Notificator>.Use().Push(new Notification()
                {
                    Status = NotificationStatus.Error,
                    Info = ex.Message
                });
            }
        }

    }
}
