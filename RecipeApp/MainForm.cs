using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RecipeApp.Models;
using RecipeApp.Data;
using RecipeApp.Builders;
using RecipeApp.Export;

namespace RecipeApp
{
    public partial class MainForm : Form
    {
        private RecipeRepository _repository;
        private List<Ingredient> _currentShoppingList;

        public MainForm()
        {
            InitializeComponent();

            _repository = new RecipeRepository();
            _currentShoppingList = new List<Ingredient>();

            LoadRecipesIntoUI(_repository.GetAll());
        }

        private void LoadRecipesIntoUI(List<Recipe> recipes)
        {
            lstRecipes.DataSource = null;
            lstRecipes.DataSource = recipes;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = txtSearch.Text;
            var results = _repository.Search(query);
            LoadRecipesIntoUI(results);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Оберіть хоча б один рецепт зі списку!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int portions = (int)numPortions.Value;
            var builder = new ShoppingListBuilder();

            foreach (Recipe selectedRecipe in lstRecipes.SelectedItems)
            {
                builder.AddRecipe(selectedRecipe, portions);
            }

            _currentShoppingList = builder.Build();

            lstShoppingList.DataSource = null;
            lstShoppingList.DataSource = _currentShoppingList;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            var editor = new RecipeEditorForm();
            if (editor.ShowDialog() == DialogResult.OK)
            {
                _repository.AddRecipe(editor.CurrentRecipe);
                LoadRecipesIntoUI(_repository.GetAll()); 
            }
        }

        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe selectedRecipe)
            {
                var editor = new RecipeEditorForm(selectedRecipe);
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    _repository.UpdateRecipe(editor.CurrentRecipe);
                    LoadRecipesIntoUI(_repository.GetAll());
                }
            }
            else
            {
                MessageBox.Show("Оберіть рецепт для редагування!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe selectedRecipe)
            {
                var confirm = MessageBox.Show($"Ви дійсно хочете видалити рецепт '{selectedRecipe.Name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    _repository.DeleteRecipe(selectedRecipe.Id);
                    LoadRecipesIntoUI(_repository.GetAll());
                }
            }
            else
            {
                MessageBox.Show("Оберіть рецепт для видалення!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {
            ExportList(new TxtExporter(), "ShoppingList.txt");
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            ExportList(new CsvExporter(), "ShoppingList.csv");
        }

        private void ExportList(IShoppingListExporter exporter, string fileName)
        {
            if (_currentShoppingList == null || _currentShoppingList.Count == 0)
            {
                MessageBox.Show("Список покупок порожній! Спочатку згенеруйте його.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                exporter.Export(_currentShoppingList, fileName);
                MessageBox.Show($"Успішно збережено у файл {fileName} (у папці з програмою)!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}