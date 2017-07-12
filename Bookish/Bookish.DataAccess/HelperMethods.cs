using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Bookish.DataAccess
{
    public class HelperMethods
    {
        public static List<Book> GetBookList()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string SqlString = "select isbn,title,name from (books join titles on BookISBN = isbn) join authors on AuthorId = authors.id";
            return (List<Book>) db.Query<Book>(SqlString);
        }
    }
}
