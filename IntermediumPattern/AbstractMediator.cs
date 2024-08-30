using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediumPattern
{
    internal abstract class AbstractMediator
    {
        protected Purchase purchase;

        protected Sale sale;

        protected Stock stock;

        public AbstractMediator()
        {
            this.purchase = new Purchase(this);
            this.sale = new Sale(this);
            this.stock = new Stock(this);
        }

        public abstract void Execute(string str, object[] objects);
    }
}
