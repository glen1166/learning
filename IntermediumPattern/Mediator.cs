using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediumPattern
{
    internal class Mediator : AbstractMediator
    {
        public override void Execute(string str, object[] objects)
        {
            if (str.Equals("purchase.buy"))
            {
                this.BuyComputer((int)objects[0]);
            }
            else if (str.Equals("sale.sell"))
            {
                this.SellComputer((int)objects[0]);
            }
            else if (str.Equals("sale.offsell"))
            {
                this.OffSell();
            }
            else if (str.Equals("stock.clear"))
            {
                this.ClearStock();
            }
        }

        private void BuyComputer(int number)
        {
            int saleStatus = this.sale.GetSaleStatus();
            if (saleStatus > 80)
            {
                Console.WriteLine("采购IBM电脑：" + number + "台");
                this.stock.Increase(number);
            }
            else
            {
                int buyNumber = number / 2;
                Console.WriteLine("采购IBM电脑：" + buyNumber + "台");
                this.stock.Increase(buyNumber);
            }
        }

        private void SellComputer(int number)
        {
            if (this.stock.GetStockNumber() < number)
            {
                this.purchase.BuyIBMComputer(number);
            }
            this.stock.Decrease(number);
        }

        private void OffSell()
        {
            Console.WriteLine("折价销售IBM电脑" + this.stock.GetStockNumber() + "台");
        }

        private void ClearStock()
        {
            this.sale.OffSale();
            this.purchase.RefuseBuyIBM();
        }
    }
}
