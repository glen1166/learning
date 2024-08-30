using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode.V2
{
    internal abstract class Corp
    {
        private Product _product;
        public Corp(Product product)
        {
            this._product = product;
        }
        public virtual void MakeMoney()
        {
            this._product.BeProducted();
            this._product.BeSelled();
        }

    }
}
