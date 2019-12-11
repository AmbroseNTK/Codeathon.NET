using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codeathon.Desktop
{
    public class SyncContext
    {
        public readonly SynchronizationContext synchronizationContext;
        public SyncContext()
        {
            synchronizationContext = SynchronizationContext.Current;
        }
    }
}
