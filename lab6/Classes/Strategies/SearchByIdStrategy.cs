using lab6.Classes.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Classes.Strategies
{
    public class SearchByIdStrategy : BaseSearchStrategy
    {
        public override List<Recipe> Search(IDatabase database, string query)
        {
            string sqlQuery = "SELECT * FROM lab6 WHERE id = @query";
            return ExecuteSearch(database, sqlQuery, cmd => cmd.Parameters.AddWithValue("@query", query));
        }
    }

}


