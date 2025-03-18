using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeesanddepartment
{

    public class Employee
    {
        public string Name;
        public int Salary;

        public Employee(string name, int salary)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be null or empty.");
            }
            else
                Name = name;

            if (salary <= 0)
            {
                Console.WriteLine("Salary must be greater than zero.");
            }
            else 
            {
                Salary = salary;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Worker's name: " + Name);
            Console.WriteLine("Worker's salary: " + Salary);
        }
    }
}
