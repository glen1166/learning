using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode
{
    internal class ClothersCorp : Crop
    {
        protected override void Produce()
        {
            Console.WriteLine("服装公司生产衣服...");
        }

        protected override void Sell()
        {
            Console.WriteLine("服装公司出售衣服...");
        }

        public override void MakeMoney()
        {
            base.MakeMoney();
            Console.WriteLine("服装公司赚小钱了...");
        }
    }
}
