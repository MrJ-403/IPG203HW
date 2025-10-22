using IPG203HW.Abstracts;
using System;

namespace IPG203HW.Models
{
    internal class ScienceBook : AbstractBook
    {
        public ScienceBook(string ISBN, string Title, string Author)
            : base(ISBN, Title, Author)
        {
        }

        public override string GetGenre()
        {
            return "Science";
        }
    }
}