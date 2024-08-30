using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediumPattern
{
    internal class Sale:AbstractColleague
    {
        public Sale(AbstractMediator mediator): base(mediator)
        {
        }

        public void SellIBMComputer(int number)
        {
            base._mediator.Execute("sale.sell", new object[] { number });
            Console.WriteLine("Sale IBM Computer: " + number);
        }

        public int GetSaleStatus()
        {
            Random random = new Random();
            int saleStatus = random.Next(100);
            Console.WriteLine("Sale Status: " + saleStatus);
            return saleStatus;
        }

        public void OffSale()
        {
            base._mediator.Execute("sale.offsell", null);
        }
    }
}
