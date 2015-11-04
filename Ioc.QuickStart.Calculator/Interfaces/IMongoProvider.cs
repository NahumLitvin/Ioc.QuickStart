using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc.QuickStart.Interfaces
{
    interface IMongoDal
    {
        void DoStuff();
    }

    class MongoDal : IMongoDal
    {
        public void DoStuff()
        {
            throw new NotImplementedException();
        }
    }
}
