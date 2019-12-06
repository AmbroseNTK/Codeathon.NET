using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon.DataModel;
using Codeathon.API.Events;

namespace Codeathon.API.Utilities
{
    public class AuthData
    {
        public event AuthenticatedHandler OnAuthenticated;

        User authUser;

        public void Set(User user)
        {
            this.authUser = user;
            OnAuthenticated?.Invoke(user);
        }

    }
}
