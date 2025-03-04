using Q1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t-----Employee Management System-----");
            Employee employee1 = new Employee(1204, "Qadeer", "DCS", 100000);
            Employee employee2 = new Employee(1205, "Waqar", "DCS", 100000.50);
            Console.WriteLine();
            Console.WriteLine("Employee 1 Detail :");

            employee1.Display();

            Console.WriteLine("Employee 2 Detail :");
            employee2.Display();

            Console.WriteLine(">Employee 1 salary increase 10% this month:");
            employee1.Increase_Salary(10);

            Console.WriteLine(">Employee 2 salary increase 15% this month:");
            employee2.Increase_Salary(15);

            Console.WriteLine("\t\t\t\t\t------------------------------------");

        }
    }
}
