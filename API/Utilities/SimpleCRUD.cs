using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon.API.Interfaces;
using Codeathon.DataModel;

namespace Codeathon.API.Utilities
{
    public abstract class SimpleCRUD<K, T> : ICRUD<K, T> 
        where T : class
        where K: IComparable
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

        public virtual void Create(T entity)
        {
            GetDbSet().Add(entity);
        }

        public virtual void Delete(K key)
        {

            T deletion = GetDbSet().ToList().Where((element) => key.CompareTo(GetKey(element)) == 0).FirstOrDefault();
            GetDbSet().Remove(deletion);
        }

        public virtual IEnumerable<T> Read(Filter<T> filter = null)
        {
            if (filter != null)
            {
                return GetDbSet().Where((entity) => filter(entity));
            }
            return GetDbSet().ToList<T>();
        }

        public virtual void Update(K key, T entity)
        {
            T updation = GetDbSet().ToList().Where((element) => key.CompareTo(GetKey(element)) == 0).FirstOrDefault();
            GetContext().Entry<T>(updation).CurrentValues.SetValues(entity);
        }

        /// <summary>
        /// Update all changes of data to database
        /// </summary>
        public virtual void SaveChanges()
        {
            GetContext().SaveChanges();
        }
    }
}
