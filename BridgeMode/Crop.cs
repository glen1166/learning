using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode
{
    internal abstract class Crop
    {
        protected abstract void Produce();

        protected abstract void Sell();

        public virtual void MakeMoney()
        {
            this.Produce();
            this.Sell();
        }
    }
}
