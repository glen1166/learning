using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.V2
{
    internal abstract class Corp
    {
        protected string? _name = "";

        protected string? _position = "";

        protected string? _salary = "";

        public Corp(string name, string position, string salary)
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
