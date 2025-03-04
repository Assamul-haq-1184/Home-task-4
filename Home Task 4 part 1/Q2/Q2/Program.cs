using Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT4
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            book.Author = "Assamul-Haq";
            book.Title = "OOP";
            book.ISBN = "978-92-95055-02-5:";
            book.Price = 500;
            book.Display();
            Console.WriteLine();
            Console.WriteLine("Discount on this book is 10%:");
            book.ApplyDiscount(10);


        }
    }
}
