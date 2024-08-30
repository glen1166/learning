using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = typeof(Class3).GetProperties().Count();

            Console.WriteLine(count);

            var c1 = new Class1(1);
            Action aa = c1.Print;

            aa();
            c1.Update(2);
            aa();

        }
    }
}
