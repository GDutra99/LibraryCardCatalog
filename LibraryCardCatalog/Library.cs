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
            //FileName();
            bool displayMenu = true;
            while (displayMenu)
            {
               displayMenu = MainMenu();
            }




        }
        public static bool MainMenu()
        {
            Console.WriteLine("Welcome to the digital library, choose an option:");
            Console.WriteLine("1) List All Books");
            Console.WriteLine("2) To Add A Book");
            Console.WriteLine("3) To Save and Exit");
            string a = Console.ReadLine();
            int x;
            int.TryParse(a, out x);


            if (x == 1)
            {
                Console.Clear();
                CardCatalog.ListBooks();
                Console.WriteLine("Press enter to continue."); //Besides of the foreach loop this is working fine and I don't think it needs change for now.
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (x == 2)
            {
                Console.Clear();
                CardCatalog.AddBook(); // changed this now we can just call the method.
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (x == 3)
            {
                //Need to add a method to save all the books.
                return false;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Option not available.");
                Console.WriteLine("Press enter to continue."); // Added this option so if the user puts a random number it won't crash.
                Console.ReadLine();
                Console.Clear();
                return true;
            }
        }
        public static void FileName()
        {
            Console.WriteLine("1) Create a new file.");
            Console.WriteLine("2) Open a file.");
            string b = Console.ReadLine();
            int y;
            int.TryParse(b, out y);
            

            
            
            //Console.ReadLine();
            //Console.Clear();
        }


    }
}
//Book b1 = new Book("Percy Jackson", "me", 2016, Genre.ActionAdventure);
//Book b2 = new Book("Percy Jackson2", "me", 2016, Genre.ActionAdventure);
//List<Book> myBooks = new List<Book>();
//myBooks.Add(b1);
//myBooks.Add(b2);
////CardCatalog.ListBooks(myBooks);
