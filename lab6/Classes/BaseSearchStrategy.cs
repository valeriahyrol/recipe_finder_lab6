using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Classes
{
    public abstract class BaseSearchStrategy : ISearchStrategy
    {
        protected List<Recipe> ExecuteSearch(db database, string sqlQuery, Action<MySqlCommand> parameterSetter)
        {
            List<Recipe> recipes = new List<Recipe>();
            database.OpenConnection();

            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, database.GetConnection()))
            {
                parameterSetter(cmd);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Recipe recipe = new Recipe
                        {
                            Id = reader.GetInt32("id"),
                            Title = reader.GetString("title"),
                            Text = reader.GetString("text")
                        };

                        recipes.Add(recipe);
                    }
                }
            }

            database.CloseConnection();
            return recipes;
        }

        public abstract List<Recipe> Search(db database, string query);
    }

    
}


