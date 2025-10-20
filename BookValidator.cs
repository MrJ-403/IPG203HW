using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IPG203HW
{
    internal static class BookValidator
    {
        public static bool IsValidISBN(string isbn)
        {
            return isbn.Length == 13 && isbn.All(char.IsDigit);
        }

        public static bool IsValidTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title) && title.Length <= 100;
        }

        public static bool IsValidAuthor(string author)
        {
            return !string.IsNullOrWhiteSpace(author) && author.All(char.IsLetterOrDigit);
        }

        public static bool IsValidPublicationYear(int year)
        {
            int currentYear = DateTime.Now.Year;
            return year <= currentYear;
        }

    }
}
