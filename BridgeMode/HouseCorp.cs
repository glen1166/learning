using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode
{
    internal class HouseCorp : Crop
    {
        protected override void Produce()
        {
            Console.WriteLine("房地产公司盖房子...");
        }

        protected override void Sell()
        {
            Console.WriteLine("房地产公司出售房子...");
        }

        public override void MakeMoney()
        {
            base.MakeMoney();
            Console.WriteLine("房地产公司赚大钱了...");
        }
    }
}
