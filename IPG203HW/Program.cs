using System;

namespace IPG203HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            BooksList books = new BooksList();
            FictionBook fictionBook = new FictionBook("1548745623145", "Space & Terraforming", "Steve Johnson");
            ScienceBook scienceBook = new ScienceBook("1658736942516", "The Human Body", "Ahmad Radwan");
            HistoryBook historyBook = new HistoryBook("2657913679823", "World War II", "Alexander H");

            scienceBook.Borrow();
            fictionBook.Borrow();
            scienceBook.Return();

            books.AddBook(fictionBook);
            books.AddBook(scienceBook);
            books.AddBook(historyBook);

            books.GetGenres();
            Console.WriteLine($"Total Books: {LibraryStats.TotalBooksCount} books\nTotal Borrowed Books: {LibraryStats.TotalBooksBorrowed} books");
            
        }
    }
}