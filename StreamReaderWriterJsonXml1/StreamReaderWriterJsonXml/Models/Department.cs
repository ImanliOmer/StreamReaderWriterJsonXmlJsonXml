using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderWriterJsonXml.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private List<Employee> _employees;
        public List<Employee> Employees 
        { 
            get 
            { return _employees; } set { _employees = value; } }
        public Department(string name, Employee employees)
        {
            Id++;
            Name = name;
            _employees.Add(employees);
        }

    }
}
