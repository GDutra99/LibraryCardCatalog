using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    public class CardCatalog
    {

        internal static void ListBooks()
        {
            Console.Clear();
            List<Book> myBooks = new List<Book>();
             foreach (Book book in myBooks)
            {
                if (book.Count == 0)
                {
                    Console.WriteLine("There are no books in the library"); //Ask Joe how can we make this work. The idea was: if there is no books added it would print that.
                                                                            //Otherwise it would print the books in the library that have been added.
                }
                else
                {
                    Console.WriteLine(book.Title, book.Author, book.YearPublished, book.Genre);
                    Console.WriteLine();
                }



                    
                    

            }
            Console.ReadLine();
        }

        public void AddBook()
        {
            Console.Clear();

            Console.WriteLine("What is the title of the book");
            string title = Console.ReadLine();

            Console.WriteLine("What is the author of the book");
            string author = Console.ReadLine();

            Console.WriteLine("What is the title of the book");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the genre of the book");
            g = Console.ReadLine();

            Genre genre = (Genre)Enum.Parse(typeof(Genre), g)


            //Book b = new Book(title, author, year, genre);






        }
    }
    
}
