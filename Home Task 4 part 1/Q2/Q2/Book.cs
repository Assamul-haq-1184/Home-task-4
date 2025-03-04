using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;
        public void Display()
        {
            //comment
            Console.WriteLine("\t\t\t\t\t-----Library Management System-----");
            Console.WriteLine("Book Detail:");
            Console.WriteLine($"->Title  : {Title}");
            Console.WriteLine($"->Author : {Author}");
            Console.WriteLine($"->ISBN   : {ISBN}");
            Console.WriteLine($"->Price  : RS:{Price}");
        }
        public void ApplyDiscount(double percentage)
        {
            Price -= Price * (percentage / 100);
            Console.WriteLine($"\t\t\t     -->New Price = RS:{Price}");
        }
    }
}
