using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level) : base(level)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Standard Console::Logger: " + message);
        }
    }
}
