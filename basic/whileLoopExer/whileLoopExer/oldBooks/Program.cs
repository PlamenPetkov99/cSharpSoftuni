using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int books = 0;
            string currentBook = Console.ReadLine();
            bool noMoreBooks = false;

            while (currentBook != searchedBook)
            {
                if(currentBook == "No More Books")
                {
                    noMoreBooks = true;
                    break;
                }
                books = books + 1;
                currentBook = Console.ReadLine();
            }

            if (noMoreBooks == true)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {books} books.");
            }
            else
            {
                Console.WriteLine($"You checked {books} books and found it.");
            }
        }
    }
}
