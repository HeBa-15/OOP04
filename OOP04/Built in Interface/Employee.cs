using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Built_in_Interface
{
    class Employee : ICloneable, IComparable
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }
        public object Clone()
        {
            return new Employee()
            {
                id = this.id,
                Name = this.Name,
                // Name = (string?) this.Name.Clone(),
                Salary = this.Salary,
                Department = (Department?)this.Department?.Clone()
            };
        }
        public override string ToString()
        {
            return $"Id: {id}, Name: {Name}, Salary: {Salary:C}";
        }


        public int CompareTo(object? obj)
        {
            Employee other = (Employee?)obj; //Explicit Casting
                                             // unsafe Casting 
            return this.Salary.CompareTo(other?.Salary);
;
            
            //if (other is null)
            //    return 1;
            
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //return 0;
        }
    }
}
