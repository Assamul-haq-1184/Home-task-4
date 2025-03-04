using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Employee
    {
        //CodeComment Assam
        public int ID;
        public string Name;
        public string Department;
        public double Salary;

        public Employee(int id, string name, string department, double salary)
        {
            ID = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public void Display()
        {

            Console.WriteLine($"->ID : {ID}");
            Console.WriteLine($"->Name : {Name}");
            Console.WriteLine($"->Department  : {Department}");
            Console.WriteLine($"->Salary  : RS:{Salary}\n");
        }
        public void Increase_Salary(double amount)
        {

            Salary += Salary * (amount / 100);
            Console.WriteLine($"\t\t\t\t\t   -->New Salary =RS{Salary}\n");
        }
    }
}
