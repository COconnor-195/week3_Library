using System;
using System.Collections.Generic;
using System.Text;

namespace week3_Library
{
    public class Book
    {
        // Private variables // 
        private string _title;
        private string _author;
        private int _isbn; 

        public string Title
        {
            get { return _title;  } 
            set 
            { _title = value;

                if (!value.Any(char.IsDigit)) 
                {
                    _title = value;

                } 
                else
                {
                    Console.WriteLine("Cannot enter number for title"); 


                }

            }

         // Public variables // 

        }

        public string Author
        {
            get { return _author; }
            set 
            { _author = value; }


        }

        public int ISBN
        {
            get { return _isbn; }
            set 
            { _isbn = value; }


        }


        // Paramaterised constructor // 
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN; 

        }

        // Methods // 
    
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");

        } 
        


    }
}

