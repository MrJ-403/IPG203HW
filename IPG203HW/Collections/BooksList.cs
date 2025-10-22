using IPG203HW.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203HW.Collections
{
    internal class BooksList
    {
        private List<AbstractBook> books;

        public BooksList()
        {
            books = new List<AbstractBook>();
        }

        //Add a Book to the books List
        public void AddBook(AbstractBook book)
        {
            books.Add(book);
        }

        //Remove a book from the books List
        public void RemoveBook(AbstractBook book)
        {
            books.Remove(book);
        }

        //Clear the Books in the List (Make the List Empty)
        public void Clear()
        {
            books.Clear();
        }

        //Outputs a Line for each book containing it's title and it's genre
        public void GetGenres()
        {
            foreach (AbstractBook book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Genre: {book.GetGenre()}");
            }
        }
    }
}
