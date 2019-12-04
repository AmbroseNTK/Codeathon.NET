using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codeathon.API.Interfaces;

namespace Codeathon.API.Utilities
{
    public abstract class AbstractCRUD<K, T>
    {
        protected abstract void Create(T entity);
        protected abstract IEnumerable<T> Read(Filter<T> filter = null);
        protected abstract void Update(K key, T entity);
        protected abstract void Delete(K key);

        protected abstract void SaveChanges();
    }
}
