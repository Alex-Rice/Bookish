using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace Bookish.ConsoleApp
{
    class DatabaseHandler
    {
        public bool AddBooksFromTextInput(NewBookViewModel newBook)
        {
            // Validify input to make sure we aren't entering in stupid data.
            // There are additional restrictions, but for now just say ISBNs must be 13 digits long.
            // Check if the ISBN in numeric.
            int isbnParseResult;
            if (Int32.TryParse(isbn, out isbnParseResult))
            {
                // Check if it is 13 digits long.
                if (isbn.Length != 13) {
                    // ISBN passed is numeric, but not 13 digits long.
                    return false;
                }
            }
            else
            {
                // ISBN passed is not numeric.
                return false;
            }

            // Title and author should be fine to not check.

            int countParseResult;
            if (!Int32.TryParse(count, out countParseResult))
            {
                // Count passed is not numeric.
                return false;
            }
            
            // Have book data. Can now check if it already exists.
        }
    }
}
*/