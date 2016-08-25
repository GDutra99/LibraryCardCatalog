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

            List<Book> myBooks = new List<Book>();
            if (myBooks.Count == 0)
            {
                Console.WriteLine("There are no books in the library");
            }
            else
            {
                foreach (Book book in myBooks) // Fixed this, now it will print the message when the book count = 0,
                                               // since we can't save the books I don't know if the foreach loop works.
                {
                    Console.WriteLine(book.Title, book.Author, book.YearPublished, book.Genre);
                    Console.WriteLine();
                }
            }
        }
        internal static void AddBook()      //Kinda fixed this thing but we need to sent the books that the user added to a file,
                                            //otherwise it won't save them.
        {


            Console.WriteLine("What is the title of the book");
            string title = Console.ReadLine();

            Console.WriteLine("What is the author of the book");
            string author = Console.ReadLine();

            Console.WriteLine("When was the book published");
            int year = Convert.ToInt32(Console.ReadLine());

            Genre genre;
            bool displayGenre;
            do
            {
                Console.WriteLine("What is the genre of the book");
                Console.WriteLine("Options are: ScienceFiction, Fiction, Satire, Drama, Action, Adventure, Romance, Mystery, Horror, & Health ");
                string g = Console.ReadLine();
                displayGenre = Enum.TryParse<Genre>(g, out genre);

            } while  (displayGenre == false);
            
   
        }
    }
}

        

    
    
    

