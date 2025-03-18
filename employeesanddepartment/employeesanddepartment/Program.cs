using System.Dynamic;

namespace employeesanddepartment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert name for department: ");
            string depName = Console.ReadLine();

            Console.Write("Insert limit for department workers: ");
            int limit = int.Parse(Console.ReadLine());

            Department dept = new Department(depName, limit);

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("Insert information about the worker No " + (i + 1));

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                int salary = int.Parse(Console.ReadLine());
            }
        }
    }
}

    
