using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeathon.API.Utilities
{
    public class AuthData
    {
        private long uid;
        private string email;

        public long Uid { get => uid; set => uid = value; }
        public string Email { get => email; set => email = value; }

        public void Set(long uid, string email)
        {
            this.uid = uid;
            this.email = email;
        }

    }
}
