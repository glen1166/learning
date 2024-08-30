using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Context
    {
        private IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void Operate()
        {
            this._strategy.Operate();
        }
    }
}
