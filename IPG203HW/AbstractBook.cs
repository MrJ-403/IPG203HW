using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203HW
{
    internal abstract class AbstractBook : IBookActions
    {
        private string isbn {get;}
        private string title { get; set; }
        private string author { get; set; }
        private bool isBorrowed;

        public AbstractBook(string ISBN, string Title, string Author)
        {
            //if (!BookValidator.IsValidISBN(ISBN)) use BookValidator in Question 5
            //    throw new ArgumentException("Invalid ISBN for Book");
            isbn = ISBN;
            title = Title;
            author = Author;
            //LibraryStats.TotalBooksCount++; use LibraryStats in Question 5
        }

        public virtual void Borrow()
        {
            isBorrowed = true;
            //LibraryStats.TotalBooksBorrowed++; use LibraryStats in Question 5
            OnBookBorrowed?.Invoke($"{title} has been borrowed");
        }

        public virtual void Return()
        {
            isBorrowed = false;
            //LibraryStats.TotalBooksBorrowed--; use LibraryStats in Question 5
            OnBookReturned?.Invoke($"{title} has been returned");
        }

        public abstract string GetGenre();

        public delegate void BookEventHandler(string message);
        public event BookEventHandler OnBookBorrowed;
        public event BookEventHandler OnBookReturned;
    }
}
