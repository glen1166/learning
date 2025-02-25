using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.V2
{
    internal class Branch : Corp
    {
        private List<Corp> _subordinateList = new List<Corp>();

        public Branch(string name, string position, string salary) : base(name, position, salary)
        {
        }

        public void AddSubordinate(Corp corp)
        {
            _subordinateList.Add(corp);
        }

        public List<Corp> GetSubordinateList()
        {
            return _subordinateList;
        }
    }
}
