using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Branch : IBranch
    {
        private string? _name = "";

        private string? _position = "";

        private string? _salary = "";

        private List<ICorp> _subordinateList = new List<ICorp>();

        public Branch(string name, string position, string salary)
        {
            _name = name;
            _position = position;
            _salary = salary;
        }

        public void AddSubordinate(ICorp corp)
        {
            _subordinateList.Add(corp);
        }

        public List<ICorp> GetSubordinate()
        {
            return _subordinateList;
        }

        public string GetInfo()
        {
            return $"Name: {_name}, Position: {_position}, Salary: {_salary}";
        }
    }
}
