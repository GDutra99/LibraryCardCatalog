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
        public static void ListBooks(List<Book> myBooks)
        {
            foreach (Book book in myBooks)
            {
                Console.WriteLine(book.Title);
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
