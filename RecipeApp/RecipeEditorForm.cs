using System;
using System.ComponentModel;
using System.Windows.Forms;
using RecipeApp.Models;

namespace RecipeApp
{
    public partial class RecipeEditorForm : Form
    {
        public Recipe CurrentRecipe { get; private set; }

        private BindingList<Ingredient> _ingredients;

        public RecipeEditorForm(Recipe recipe = null)
        {
            InitializeComponent();

            if (recipe == null)
            {
                CurrentRecipe = new Recipe { DefaultPortions = 1 };
                this.Text = "Створення нового рецепту";
            }
            else
            {
                CurrentRecipe = recipe.Clone();
                this.Text = "Редагування рецепту";
            }

            txtRecipeName.Text = CurrentRecipe.Name;
            numDefaultPortions.Value = CurrentRecipe.DefaultPortions > 0 ? CurrentRecipe.DefaultPortions : 1;

            _ingredients = new BindingList<Ingredient>(CurrentRecipe.Ingredients);
            lstIngredients.DataSource = _ingredients;
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngName.Text) || string.IsNullOrWhiteSpace(txtIngUnit.Text))
            {
                MessageBox.Show("Заповніть назву та одиницю виміру інгредієнта!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newIng = new Ingredient
            {
                Name = txtIngName.Text.Trim(),
                Quantity = (double)numIngQty.Value,
                Unit = txtIngUnit.Text.Trim()
            };

            _ingredients.Add(newIng);

            txtIngName.Clear();
            numIngQty.Value = 1;
            txtIngUnit.Clear();
            txtIngName.Focus();
        }

        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedItem is Ingredient selectedIng)
            {
                _ingredients.Remove(selectedIng);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecipeName.Text))
            {
                MessageBox.Show("Введіть назву рецепта!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrentRecipe.Name = txtRecipeName.Text.Trim();
            CurrentRecipe.DefaultPortions = (int)numDefaultPortions.Value;

            this.DialogResult = DialogResult.OK; 
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}