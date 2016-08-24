using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            Book b1 = new Book("Percy Jackson", "me", 2016, Genre.ActionAdventure);
            Book b2 = new Book("Percy Jackson2", "me", 2016, Genre.ActionAdventure);
            List<Book> myBooks = new List<Book>();
            myBooks.Add(b1);
            myBooks.Add(b2);
            //CardCatalog.ListBooks(myBooks);

            Console.WriteLine("Welcome to the digital library");
            Console.WriteLine("Press 1 List All Books");
            Console.WriteLine("Press 2 for Add A Book");
            Console.WriteLine("Press 3 for Save and Exit");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                CardCatalog.ListBooks(myBooks);
            }
            else if (a== 2)
            {
                Console.WriteLine("This is where the Add A Book method will go");
            }
            else if (a == 3)
            {
                Console.WriteLine("This is where the Save & Exit method will go");
            }

            Console.ReadLine();




        }


    }
}
