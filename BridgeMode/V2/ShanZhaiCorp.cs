using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode.V2
{
    internal class ShanZhaiCorp : Corp
    {
        public ShanZhaiCorp(Product product) : base(product)
        {
        }

        public override void MakeMoney()
        {
            base.MakeMoney();
            this.Sell();
        }

        private void Sell()
        {
            Console.WriteLine("山寨公司赚大钱了...");
        }
    }
}
