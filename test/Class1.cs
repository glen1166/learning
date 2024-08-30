using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Class1
    {
        private int _value;
        public Class1(int value)
        {
            _value = value;
        }

        public void Update(int value)
        {
            _value = value;
        }

        public void Print()
        {
            Console.WriteLine(_value);
        }
    }
}
