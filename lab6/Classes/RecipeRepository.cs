using lab6.Classes.DataBase;
using lab6.Classes.Strategies;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Classes
{
    public class RecipeRepository : IRecipeRepository
    {
        private static RecipeRepository? instance = null;
        private IDatabase database = new DB();

        private RecipeRepository() { }

        public static RecipeRepository Instance()
        {
            if (instance == null)
            {
                instance = new RecipeRepository();
            }
            return instance;
        }

        public List<Recipe> SearchRecipes(ISearchStrategy searchStrategy, string query)
        {
            return searchStrategy.Search(database, query);
        }

        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();

            string query = "SELECT * FROM lab6";
            try
            {
                database.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, database.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recipe recipe = new Recipe
                            {
                                Id = reader.GetInt32("id"),
                                Title = reader.GetString("title")!,
                                Text = reader.GetString("text")!
                            };

                            recipes.Add(recipe);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                database.CloseConnection();
            }

            return recipes;
        }
    }
}
