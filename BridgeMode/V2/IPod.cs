using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode.V2
{
    internal class IPod : Product
    {
        public override void BeProducted()
        {
            Console.WriteLine("生产出的iPod是这样的...");
        }

        public override void BeSelled()
        {
            Console.WriteLine("生产出的iPod卖出去了...");
        }
    }
}
