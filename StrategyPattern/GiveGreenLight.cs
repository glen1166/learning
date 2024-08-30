using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class GiveGreenLight : IStrategy
    {
        public void Operate()
        {
            Console.WriteLine("求吴国太开个绿灯,放行!");
        }
    }
}
