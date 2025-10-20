using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203HW
{
    internal class BooksList
    {
        private List<AbstractBook> books;
        
        public BooksList()
        {
            books = new List<AbstractBook>();
        }

        public void AddBook(AbstractBook book) 
        { 
            books.Add(book);
        }

        public void RemoveBook(AbstractBook book)
        {
            books.Remove(book);
        }

        public void Clear()
        {
            books.Clear();
        }

        public void GetGenres()
        {
            foreach (AbstractBook book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Genre: {book.GetGenre()}");
            }
        }
    }
}
