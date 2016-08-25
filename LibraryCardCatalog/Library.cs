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

            List<Book> myBooks = new List<Book>(); // *Important* so for the list to be used by all of the methods it needed to be delcared in main so its been moved from the ListBooks method to here
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu(myBooks);
            }




        }
        public static bool MainMenu(List<Book> myBooks)//all of the methods now are given access to the list myBooks through the argument of the method
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
                CardCatalog.ListBooks(myBooks); //when invoking the method ListBooks I need to pass myBooks into the argument
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (x == 2)
            {
                Console.Clear();
                CardCatalog.AddBook(myBooks); // Same deal as ListBooks we need to pass myBooks in the argument
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (x == 3)
            {
                //so essentially had to run the FileName method in main in order to keep it from being garbage collected
                // commented out your code for a menu option as I only worked on the "Create a new file" option
                //the "Open a file" option I did not complete,  the if loop you had for that method I kept it is commented out below for when we add Open a file

                            //Console.WriteLine("1) Create a new file.");
                            //Console.WriteLine("2) Open a file.");
                            //string b = Console.ReadLine();
                            //int y;
                            //int.TryParse(b, out y);
                            //string FileName = "placeholder";

                Console.Clear();
                Console.WriteLine("Please create a file name");
                string FileName = Console.ReadLine(); // this is where the user inputs FileName for the SaveBook method
                CardCatalog.BookSave(myBooks,FileName);//calling the Save method
                Console.Clear();
                
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
        //public static string FileName()
        //{
        //    return
        //if (y == 1)
        //   {

        //   }
        //   else if (y == 2)
        //   {
        //       Console.Clear();
        //       CardCatalog.AddBook(myBooks); // changed this now we can just call the method.
        //       Console.WriteLine("Press enter to continue.");
        //       Console.ReadLine();
        //       Console.Clear();
        //       return true;


        //   }
        //}






        //Console.ReadLine();
        //Console.Clear();
    }


}

//Book b1 = new Book("Percy Jackson", "me", 2016, Genre.ActionAdventure);
//Book b2 = new Book("Percy Jackson2", "me", 2016, Genre.ActionAdventure);
//List<Book> myBooks = new List<Book>();
//myBooks.Add(b1);
//myBooks.Add(b2);
////CardCatalog.ListBooks(myBooks);
