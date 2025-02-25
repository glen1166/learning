using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Leaf:ILeaf
    {
        private string? _name = "";

        private string? _position = "";

        private string? _salary = "";

        public Leaf(string name, string position, string salary)
        {
            _name = name;
            _position = position;
            _salary = salary;
        }

        public string GetInfo()
        {
            return $"Name: {_name}, Position: {_position}, Salary: {_salary}";
        }
    }
}
