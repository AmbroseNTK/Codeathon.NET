using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codeathon.DataModel;

namespace Codeathon.API.Events
{
    public delegate void LoginSuccessHandler();
    public delegate void RegisterSuccessHandler();
    public delegate void AuthenticatedHandler(User auth);
}
