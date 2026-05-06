using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp10
{
    internal class Book :IBook
    {

        private string title;
        private string author;
        private int year;
        private int pages;


        public string Title
        {
            get
            {
                return title;
            }
          private  set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    title = value;

                }

                else
                {
                    throw new ArgumentException("Title cannot be empty.");
                }


            }
        }
        public string Author
        {
            
                get
            {
                return author;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Author cannot be empty.");

                }

                author = value;


            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            private set
            {

                if(value>=1450 && value <= 2026)
                {
                    year = value;
                }

                else
                {
                    throw new ArgumentException("Year must be between 1450 and 2026.");

                    
                }
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            private set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    throw new ArgumentException("Pages must be positive.");
                }

            }
        }


        public Book(string title, string author, int year, int pages)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.Pages = pages;
        }


        public bool isLongBook()
        {
            return Pages >= 500;

        }


        public override string ToString()
        {
            return $"The {this.Title} by {this.Author}, {this.Year}, {this.Pages} pages";
        }

    }
}
