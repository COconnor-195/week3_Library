using System;
using System.Collections.Generic;
using System.Text;

namespace week3_Library
{
    public class Book
    {
       public string Title;
       public string Author;
       public int ISBN; 

    
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");

        } 
        

        }
}




