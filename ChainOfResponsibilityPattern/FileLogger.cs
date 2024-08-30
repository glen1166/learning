using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal class FileLogger : AbstractLogger
    {
        public FileLogger(int level) : base(level)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
