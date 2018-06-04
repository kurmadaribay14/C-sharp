using System;

namespace lesson6
{
    public class Book
    {
        public string Title {get; set;}
        public string Author {get; set;}
        public DateTime Published  {get; set;}
        public int Pages  {get; set;}

        public string ReadPage(int pageNumber)
        {
            return $"Content: {pageNumber}";
        }

        public Book (string title, string Author)
        {
            Title = title;
            this.Author = Author;
        }

        public Book ()
        {
        }


    }
    public class AcademyBook:Book
    {

        public AcademyBook (string title, string Author): base(title,Author)
        {

        }
        public int Difficulty {get; set;}
        public string SubjectArea {get; set;}

        public void MakeNote (int pageNumber, string note)
        {
            System.Console.WriteLine($"Made a note on page {pageNumber} about {note}");
        }

         public string ReadPage(int pageNumber, int Amount)
         {
             string output = "";
             for (int i=pageNumber; i<pageNumber+Amount;i++)
             {
                 output+=ReadPage(pageNumber+Amount);
             }
             return output;
         }

    }
}

