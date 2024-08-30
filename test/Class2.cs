using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Class2
    {
        private int _value;
        private readonly Lazy<Class1> c1;

        public Class2()
        {
            c1 = new Lazy<Class1>(() => new Class1(_value));
        }

        public void Set(int value)
        {
            _value = value;
            c1.Value.Print();
        }
    }
}
