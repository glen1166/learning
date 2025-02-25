using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.V2
{
    internal class Leaf : Corp
    {
        public Leaf(string name, string position, string salary) : base(name, position, salary)
        {
        }
    }
}
