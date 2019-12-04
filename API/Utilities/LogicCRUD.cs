using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon.API.Interfaces;

namespace Codeathon.API.Utilities
{
    /// <summary>
    /// Extending when you want to do some bussiness logic before run CRUD methods
    /// </summary>
    /// <typeparam name="K">Entity's key</typeparam>
    /// <typeparam name="T">Entity's type</typeparam>
    public abstract class LogicCRUD<K,T> : AbstractCRUD<K, T> 
        where K : IComparable
        where T : class
    {
        /// <summary>
        /// Put the set of entities from Db Context
        /// </summary>
        /// <returns>Managed data entities</returns>
        protected abstract DbSet<T> GetDbSet();
        /// <summary>
        /// How to get the Entity's Key from a specific entity
        /// </summary>
        /// <param name="entity">The key</param>
        /// <returns></returns>
        protected abstract K GetKey(T entity);
        /// <summary>
        /// The Db Context
        /// </summary>
        /// <returns>Used Db Context</returns>
        protected abstract DbContext GetContext();

        protected override void Create(T entity)
        {

            GetDbSet().Add(entity);
        }

        protected override void Delete(K key)
        {
            T deletion = GetDbSet().ToList().Where((element) => key.CompareTo(GetKey(element)) == 0).FirstOrDefault();
            GetDbSet().Remove(deletion);
        }

        protected override IEnumerable<T> Read(Filter<T> filter = null)
        {
            if (filter != null)
            {
                return GetDbSet().ToList().Where((entity) => filter(entity));
            }
            return GetDbSet().ToList<T>();
        }

        protected override void Update(K key, T entity)
        {
            T updation = GetDbSet().ToList().Where((element) => key.CompareTo(GetKey(element)) == 0).FirstOrDefault();
            GetContext().Entry<T>(updation).CurrentValues.SetValues(entity);
        }

        protected override void SaveChanges()
        {
            GetContext().SaveChanges();
        }
    }
}
