using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeathon.API.Utilities
{
    public class FileStorage
    {
        public string root = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "storage");
        public void CopyFileTo(string src, string dest)
        {
           
        }
    }
}
