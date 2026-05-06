using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal interface IBook
    {
         string Title { get;  }
         string Author { get;  }
        int Year { get; }
         int Pages { get; }


        bool isLongBook();

      

    }
}
