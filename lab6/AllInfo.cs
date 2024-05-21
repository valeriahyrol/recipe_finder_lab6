using lab6.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace lab6
{
    public partial class AllInfo : Form
    {
        private RecipeController controller;
        private DataGridView dataGridView;

        public AllInfo()
        {
            InitializeComponent();
            controller = new RecipeController(this);
            InitializeDataGridView();
            LoadRecipes();
        }

        private void InitializeDataGridView()
        {
            dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false,
                BackgroundColor = Color.NavajoWhite,
                DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Engravers MT", 10) }
            };

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "Title" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Text", DataPropertyName = "Text" });

            this.Controls.Add(dataGridView);
        }

        public void DisplayRecipes(List<Recipe> recipes)
        {
            dataGridView.DataSource = recipes;
        }

        private void LoadRecipes()
        {
            var recipes = controller.LoadRecipes();
            DisplayRecipes(recipes);
        }
    }
}
