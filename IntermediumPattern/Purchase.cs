using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediumPattern
{
    internal class Purchase : AbstractColleague
    {
        public Purchase(AbstractMediator mediator) : base(mediator)
        {
        }

        public void BuyIBMComputer(int number)
        {
            base._mediator.Execute("purchase.buy", new object[] { number });
        }

        public void RefuseBuyIBM()
        {
            Console.WriteLine("Do not buy IBM computer");
        }
    }
}
