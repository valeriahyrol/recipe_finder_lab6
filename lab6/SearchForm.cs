using lab6.Classes;
using lab6.Classes.Strategies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class SearchForm : Form
    {
        private RecipeRepository repository;

        public SearchForm()
        {
            InitializeComponent();
            repository = RecipeRepository.Instance();
            SearchButton.Click += SearchButton_Click;
        }

        private void SearchButton_Click(object? sender, EventArgs e)
        {
            string query = SearchTextBox.Text;

            if (!IsValidQuery(query))
            {
                MessageBox.Show("Invalid input. Please enter a valid search query.");
                return;
            }

            ISearchStrategy? strategy = GetSearchStrategy();

            if (strategy == null)
            {
                MessageBox.Show("Please select a search criteria.");
                return;
            }

            List<Recipe> results = repository.SearchRecipes(strategy, query);
            DisplayResults(results);
        }

        private bool IsValidQuery(string query)
        {
            return !string.IsNullOrEmpty(query) && query.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c));
        }

        private ISearchStrategy? GetSearchStrategy()
        {
            if (SearchByNameRadioButton.Checked)
            {
                return new SearchByNameStrategy();
            }
            if (SearchByIngredientsRadioButton.Checked)
            {
                return new SearchByIngredientsStrategy();
            }
            if (SearchByIdRadioButton.Checked)
            {
                return new SearchByIdStrategy();
            }

            return null;
        }

        private void DisplayResults(List<Recipe> recipes)
        {
            if (recipes.Count == 0)
            {
                MessageBox.Show("No recipes found.");
            }
            else
            {
                foreach (var recipe in recipes)
                {
                    MessageBox.Show($"Recipe: {recipe.Title}, Ingredients: {recipe.Text}");
                }
            }

            ResultsDataGridView.DataSource = recipes;
        }
    }
}
