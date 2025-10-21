using System;

namespace IPG203HW
{
    internal class HistoryBook : AbstractBook
    {
        public HistoryBook(string ISBN, string Title, string Author)
            : base(ISBN, Title, Author)
        {
        }

        public override string GetGenre()
        {
            return "History";
        }
    }
}