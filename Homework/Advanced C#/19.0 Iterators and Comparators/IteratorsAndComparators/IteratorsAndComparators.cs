﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class IteratorsAndComparators
    {
        static void Main(string[] args)
        {
            //Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            //Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            //Book bookThree = new Book("The Documents in the Case", 1930);
            //Library libraryOne = new Library();
            //Library libraryTwo = new Library(bookOne, bookTwo, bookThree);


            //Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            //Book bookTwo = new Book("The Documents in the Case", 2002,
            //    "Dorothy Sayers", "Robert Eustace");
            //Book bookThree = new Book("The Documents in the Case", 1930);
            //Library libraryOne = new Library();
            //Library libraryTwo = new Library(bookOne, bookTwo, bookThree);
            //foreach (var book in libraryTwo)
            //{
            //    Console.WriteLine(book.Title);
            //}


            //Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            //Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            //Book bookThree = new Book("The Documents in the Case", 1930);

            //Library libraryOne = new Library();
            //Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            //foreach (var book in libraryTwo)
            //{
            //    Console.WriteLine(book);
            //}



            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Library library = new Library(bookOne, bookTwo, bookThree);
        }
    }
}
