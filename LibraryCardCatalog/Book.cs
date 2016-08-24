﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
     public class Book
    {
        public int Count;
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        public Genre Genre { get; set; }

        public Book(string title, string author, int yearPublished, Genre genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
            Count++; // not sure if this works yet.
        }
        

    }

    
    public enum Genre
    {
        ScienceFiction,
        Fiction,
        Satire,
        Drama,
        ActionAdventure,
        Romance,
        Mystery,
        Horror,
        SelfHelp,
        Health,
        Children,
        Science,
        History,
        Poetry,
        Comics,
        Art,
        Cookbooks

    }
}
