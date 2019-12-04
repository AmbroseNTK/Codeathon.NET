using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeathon.API.Interfaces
{
    public delegate bool Filter<T>(T current);
    public interface ICRUD<K, T>
    {
        void Create(T entity);
        IEnumerable<T> Read(Filter<T> filter = null);
        void Update(K key, T entity);
        void Delete(K key);

        void SaveChanges();

    }
}
