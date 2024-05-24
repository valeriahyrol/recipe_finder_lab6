using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Classes
{
    public class SearchByIngredientsStrategy : BaseSearchStrategy
    {
        public override List<Recipe> Search(IDatabase database, string query)
        {
            string sqlQuery = "SELECT * FROM lab6 WHERE text LIKE @query";
            return ExecuteSearch(database, sqlQuery, cmd => cmd.Parameters.AddWithValue("@query", "%" + query + "%"));
        }
    }
}
