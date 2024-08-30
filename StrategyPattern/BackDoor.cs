using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class BackDoor : IStrategy
    {
        public void Operate()
        {
            Console.WriteLine("找乔国老帮忙，让吴国太给孙权施加压力");
        }
    }
}
