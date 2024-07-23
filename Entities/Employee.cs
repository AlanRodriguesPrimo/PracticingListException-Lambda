using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas.Entities
{
    class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee() { }

        public Employee( string name, double salary)
        {
            Id = Guid.NewGuid();
            Name = name;
            Salary = salary;
        }
        public void SalaryIncrease(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }

    }
}
