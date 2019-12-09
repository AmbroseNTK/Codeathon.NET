using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codeathon.API.Interfaces;

namespace Codeathon.API.Utilities
{
    public abstract class Service<T>
    {
        private static T instance;

        public static T Use(object[] init = null )
        {
            
            if(instance == null)
            {
                instance = (T)Activator.CreateInstance(typeof(T), init == null ? (new object[0]) : init);
            }
            return instance;
        }
    }
}
