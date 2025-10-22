using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203HW
{
    internal abstract class AbstractBook : IBookActions
    {
        private readonly string isbn;
        private string title;
        private string author;
        private bool isBorrowed;

        public string Title
        {
            get { return title; }
            set {
                if(BookValidator.IsValidTitle(value))
                    title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if(BookValidator.IsValidAuthor(value))
                    author = value;
            }
        }


        public AbstractBook(string ISBN, string Title, string Author)
        {
            if (!BookValidator.IsValidISBN(ISBN))
                throw new ArgumentException("Invalid ISBN for Book");
            isbn = ISBN;
            title = Title;
            author = Author;
            LibraryStats.TotalBooksCount++;
        }

        //Borrow the book, invokes the OnBookBorrowed Event
        public virtual void Borrow()
        {
            isBorrowed = true;
            LibraryStats.TotalBooksBorrowed++;
            OnBookBorrowed?.Invoke($"{title} has been borrowed");
        }

        //Return the book, invokes the OnBookReturn Event
        public virtual void Return()
        {
            isBorrowed = false;
            LibraryStats.TotalBooksBorrowed--;
            OnBookReturned?.Invoke($"{title} has been returned");
        }

        public string GetISBN()
        {
            return isbn;
        }

        public bool IsBorrowed()
        {
            return isBorrowed;
        }

        //Should be overriden in children classes
        public abstract string GetGenre();
        
        public delegate void BookEventHandler(string message);
        public event BookEventHandler OnBookBorrowed;
        public event BookEventHandler OnBookReturned;
    }
}
