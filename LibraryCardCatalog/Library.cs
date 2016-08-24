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
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();

            }
        }            
        
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the digital library, choose an option:");
            Console.WriteLine("1) List All Books");
            Console.WriteLine("2) Add A Book");
            Console.WriteLine("3) Save and Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                List<Book> myBooks = new List<Book>();
                CardCatalog.ListBooks();
                return true;
            }
            else if (result == "2")
            {
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
            
            
        }
        
            

        

       
    }
}



//Book b1 = new Book("Percy Jackson", "me", 2016, Genre.ActionAdventure);
//Book b2 = new Book("Percy Jackson2", "me", 2016, Genre.ActionAdventure);
//List<Book> myBooks = new List<Book>();
//myBooks.Add(b1);
//myBooks.Add(b2);
//CardCatalog.ListBooks(myBooks);