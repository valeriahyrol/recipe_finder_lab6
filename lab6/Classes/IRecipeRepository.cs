using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Classes
{
    public interface IRecipeRepository
    {
        List<Recipe> SearchRecipes(ISearchStrategy searchStrategy, string query);
        List<Recipe> GetAllRecipes();
    }
}
