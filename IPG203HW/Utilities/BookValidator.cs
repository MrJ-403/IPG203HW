using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IPG203HW.Utilities
{
    internal static class BookValidator
    {
        //Check if the ISBN is Valid
        public static bool IsValidISBN(string isbn)
        {
            return isbn.Length == 13 && isbn.All(char.IsDigit);
        }

        //Check if the Title is Valid
        public static bool IsValidTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title) && title.Length <= 100;
        }

        //Check if the Author Name is Valid
        public static bool IsValidAuthor(string author)
        {
            return !string.IsNullOrWhiteSpace(author) && author.All(char.IsLetterOrDigit);
        }

        //Check if the Year of Publication is Valid
        public static bool IsValidPublicationYear(int year)
        {
            int currentYear = DateTime.Now.Year;
            return year <= currentYear;
        }

    }
}
