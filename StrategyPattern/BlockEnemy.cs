using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class BlockEnemy : IStrategy
    {
        public void Operate()
        {
            Console.WriteLine("孙夫人断后，挡住追兵");
        }
    }
}
