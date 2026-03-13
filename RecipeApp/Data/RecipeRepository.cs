using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using RecipeApp.Models;

namespace RecipeApp.Data
{
    public class RecipeRepository
    {
        private readonly string _filePath;
        private List<Recipe> _recipes;

        public RecipeRepository(string filePath = "recipes.json")
        {
            _filePath = filePath;
            _recipes = new List<Recipe>();
            LoadRecipes();
        }

        public List<Recipe> GetAll()
        {
            return _recipes;
        }

        public void AddRecipe(Recipe recipe)
        {
            _recipes.Add(recipe);
            SaveRecipes();
        }

        public List<Recipe> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return _recipes;

            query = query.ToLower();

            return _recipes.Where(r =>
                r.Name.ToLower().Contains(query) ||
                r.Ingredients.Any(i => i.Name.ToLower().Contains(query))
            ).ToList();
        }

        private void SaveRecipes()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(_recipes, options);
            File.WriteAllText(_filePath, json);
        }

        private void LoadRecipes()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                _recipes = JsonSerializer.Deserialize<List<Recipe>>(json) ?? new List<Recipe>();
            }

            if (_recipes.Count == 0)
            {
                SeedData();
            }
        }

        public void UpdateRecipe(Recipe updatedRecipe)
        {
            var index = _recipes.FindIndex(r => r.Id == updatedRecipe.Id);
            if (index != -1)
            {
                _recipes[index] = updatedRecipe;
                SaveRecipes();
            }
        }

        public void DeleteRecipe(string id)
        {
            var recipe = _recipes.FirstOrDefault(r => r.Id == id);
            if (recipe != null)
            {
                _recipes.Remove(recipe);
                SaveRecipes();
            }
        }

        public void Clear()
        {
            _recipes.Clear();
            SaveRecipes();
        }

        private void SeedData()
        {
            AddRecipe(new Recipe
            {
                Name = "Омлет",
                DefaultPortions = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Яйце", Quantity = 2, Unit = "шт" },
                    new Ingredient { Name = "Молоко", Quantity = 50, Unit = "мл" },
                    new Ingredient { Name = "Сіль", Quantity = 2, Unit = "г" }
                }
            });

            AddRecipe(new Recipe
            {
                Name = "Борщ",
                DefaultPortions = 4,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Буряк", Quantity = 1, Unit = "шт" },
                    new Ingredient { Name = "М'ясо", Quantity = 300, Unit = "г" },
                    new Ingredient { Name = "Картопля", Quantity = 400, Unit = "г" }
                }
            });
        }
    }
}
