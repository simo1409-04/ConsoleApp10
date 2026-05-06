using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp10
{
    internal class Library
    {

        private string name;

        private readonly List<IBook> books;


        public IReadOnlyCollection<IBook> Books => books.AsReadOnly();

        public string Name
        {
            get { return name; }
                private set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    name = value;
                }


            }
        }




        public Library(string name)
        {

            this.Name = name;
            books = new List<IBook>();

        }



        public void AddBook(IBook book)
        {


           if(book==null || books.Any(x=>x.Title==book.Title)) 
            {

                throw new ArgumentException("The book is already in the Library");

            }

            books.Add(book);


        }

        public bool RemoveBook(string title)
        {
            bool isRemoved = false;

            if (books.Any(x => x.Title == title))
            {


                IBook book = books.Find(x => x.Title == title);

                books.Remove(book);

                 isRemoved = true;

            }

            return isRemoved;

        }



        public List<IBook> GetBooksByAuthor(string author)
        {

            List<IBook> chosenBooks = books.Where(x => x.Author == author).ToList();

            return chosenBooks;


        }

        public List<IBook> GetLongBooks()
        {

            List<IBook> chosenBooks = books.Where(x => x.IsLongBook()).ToList();

            return chosenBooks;


        }


        public IBook GetNewestBook()
        {

            IBook NewestBook = books.OrderByDescending(x => x.Year).First();

            return NewestBook;
        }


        public int GetAveragePages()
        {

            if (books.Count == 0)
            {
                return 0;
            }

            int averageNumberCount = (int)books.Average(x => x.Pages);

            return averageNumberCount;

        }

    }
}
