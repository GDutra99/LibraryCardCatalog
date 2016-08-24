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
            CardCatalog.ListBooks(myBooks);

        }

       
    }
}
