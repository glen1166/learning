using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode.V2
{
    internal class HouseCorp : Corp
    {
        public HouseCorp(House house) : base(house)
        {
        }

        public override void MakeMoney()
        {
            base.MakeMoney();
            this.Sell();
        }

        private void Sell()
        {
            Console.WriteLine("房地产公司赚大钱了...");
        }
    }
}
