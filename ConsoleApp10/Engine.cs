using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace ConsoleApp10
{
    internal class Engine
    {


        public void Run()
        {
            Library library = new Library("City Library");

            library.AddBook(new Book("Harry Potter", "J.K. Rowling", 2006, 200));
            library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 1937, 510));
            library.AddBook(new Book("1984", "George Orwell", 1949, 328));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 180));
            library.AddBook(new Book("Dune", "Frank Herbert", 1965, 412));
            library.AddBook(new Book("The Alchemist", "Stephen King", 1988, 608)); 
            library.AddBook(new Book("The Shining", "Stephen King", 1977, 447)); 


            PrintAllBooks(library);
            PrintLongBooks(library);
            PrintBooksByAuthor(library);
            PrintAvaragePages(library);
            PrintNewestBook(library);

        }


        public void PrintAllBooks(Library library)
        {

            Console.WriteLine("All books:");
            Console.WriteLine(string.Join(Environment.NewLine, library.Books));

        }

        public void PrintLongBooks(Library library)
        {



            Console.WriteLine("Long books:");
            Console.WriteLine(string.Join(Environment.NewLine, library.GetLongBooks()));


        }

        public void PrintBooksByAuthor(Library library)
        {


            if(library.GetBooksByAuthor("Stephen King").Count==0)
            {
                return;
            }

            Console.WriteLine("Books by author:");

            Console.WriteLine(string.Join(Environment.NewLine, library.GetBooksByAuthor("Stephen King")));




        }

        public void PrintAvaragePages(Library library)
        {

            int avaragePages = library.GetAveragePages();

            Console.WriteLine("Average pages:");

            Console.WriteLine(avaragePages);




        }
        public void PrintNewestBook(Library library)
        {

            Book NewestBook = (Book)library.GetNewestBook();

            Console.WriteLine("Newest book:");

            Console.WriteLine(NewestBook);




        }
    }
}
