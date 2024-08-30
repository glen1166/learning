using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode.V2
{
    internal class House : Product
    {
        public override void BeProducted()
        {
            Console.WriteLine("房地产公司盖房子...");
        }

        public override void BeSelled()
        {
            Console.WriteLine("房地产公司出售房子...");
        }
    }
}
