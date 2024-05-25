using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Classes
{
    public class RecipeController
    {
        private AllInfo view;
        private IRecipeRepository repository;

        public RecipeController(AllInfo view, IRecipeRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }

        public List<Recipe> LoadRecipes()
        {
            return repository.GetAllRecipes();
        }
    }
}
