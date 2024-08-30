using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediumPattern
{
    internal class Stock : AbstractColleague
    {
        public Stock(AbstractMediator mediator) : base(mediator)
        {
        }

        private static int COMPUTER_NUMBER = 100;

        public void Increase(int number)
        {
            COMPUTER_NUMBER += number;
            Console.WriteLine("The number of computers in stock is: " + COMPUTER_NUMBER);
        }

        public void Decrease(int number)
        {
            COMPUTER_NUMBER -= number;
            Console.WriteLine("The number of computers in stock is: " + COMPUTER_NUMBER);
        }

        public int GetStockNumber()
        {
            return COMPUTER_NUMBER;
        }

        public void ClearStock()
        {
            Console.WriteLine("Clearing the stock: " + COMPUTER_NUMBER);
            base._mediator.Execute("stock.clear", null);
        }
    }
}
