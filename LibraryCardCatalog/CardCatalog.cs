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
    }
    
}
