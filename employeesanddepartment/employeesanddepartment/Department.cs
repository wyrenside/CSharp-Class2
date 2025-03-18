using employeesanddepartment;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace employeesanddepartment                                         
{
    public class Department
    {
        string DepName;
        int EmployeeLimit;
        Employee[] Employees;
        int EmployeeCount = 0;

        public Department(string depName, int employeeLimit)
        {
            DepName = depName;

            if (employeeLimit <= 0)
            {
                throw new ArgumentException("Every department must have at least one worker");
            }
            else
                EmployeeLimit = employeeLimit;

            Employees = new Employee[EmployeeLimit];
        }

        public void AddEmployee(Employee employee)
        {
            if (EmployeeCount >= EmployeeLimit)
            {
                Console.WriteLine("Cannot add more employees. Department limit reached.");
                return;
            }
            else
            {
                Employees[EmployeeCount] = employee;
                EmployeeCount++;
                Console.WriteLine("New worker " + employee.Name + " added.");
            }
        }

        public Employee[] GetAllEmployees()
        {
            Employee[] currentEmployees = new Employee[EmployeeCount];
            Array.Copy(Employees, currentEmployees, EmployeeCount);
            return currentEmployees;
        }
    }
}

