﻿using System;
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

        public RecipeController(AllInfo view)
        {
            this.view = view;
            this.repository = RecipeRepository.Instance();
        }

        public List<Recipe> LoadRecipes()
        {
            return repository.GetAllRecipes();
        }
    }
}
