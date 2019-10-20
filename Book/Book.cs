using System;
namespace NewAssignment
{
    public class Book
    {

        public string title;
        public string author;
        public int page;
        public string iSBN;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentOutOfRangeException("Title must be longer than 2 characters");
                }
            }
        }
        
        public int Page
        {
            get
            {
                return page;
            }
            set
            {
                if (!(page < 10 && page > 1000))
                {
                   throw new System.ArgumentException("Page must be between 10 than to 1000 characters");
                }
            }
        }

        public string ISBN
        {
   
            get
            {
                return iSBN;
            }
            set
            {
                if (iSBN.Length != 13)
                {
                    throw new System.ArgumentException("ISBN must be exactly 13 characters");
                }
            }
        }

        public Book(string Title, string Author, int Page, string ISBN)
        {
            title = Title;
            author = Author;
            page = Page;
            iSBN = ISBN; 
        }
    }
}
