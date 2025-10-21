using System;

namespace IPG203HW
{
    internal class FictionBook : AbstractBook
    {
        public FictionBook(string ISBN, string Title, string Author)
            : base(ISBN, Title, Author)
        {
        }

        public override string GetGenre()
        {
            return "Fiction";
        }
    }

}
