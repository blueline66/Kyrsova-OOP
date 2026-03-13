using System.Collections.Generic;
using System.Linq;
using Xunit;
using RecipeApp.Models;
using RecipeApp.Data;
using System.IO;

namespace RecipeApp.Tests
{
    public class RecipeRepositoryTests
    {
        private RecipeRepository GetTestRepository()
        {
            var tempFile = "test_recipes.json";
            if (File.Exists(tempFile)) File.Delete(tempFile);

            var repo = new RecipeRepository(tempFile);

            repo.Clear();

            repo.AddRecipe(new Recipe
            {
                Name = "Борщ",
                Ingredients = new List<Ingredient> { new Ingredient { Name = "Буряк" } }
            });

            repo.AddRecipe(new Recipe
            {
                Name = "Салат",
                Ingredients = new List<Ingredient> { new Ingredient { Name = "Помідор" }, new Ingredient { Name = "Огірок" } }
            });

            return repo;
        }

        [Fact]
        public void Search_ShouldReturnRecipe_WhenSearchingByName()
        {
            var repo = GetTestRepository();

            var results = repo.Search("Борщ");

            Assert.Single(results);
            Assert.Equal("Борщ", results[0].Name);
        }

        [Fact]
        public void Search_ShouldReturnRecipe_WhenSearchingByIngredient()
        {
            var repo = GetTestRepository();

            var results = repo.Search("огірок"); 

            Assert.Single(results);
            Assert.Equal("Салат", results[0].Name);
        }

        [Fact]
        public void Search_ShouldReturnAll_WhenQueryIsEmpty()
        {
            var repo = GetTestRepository();

            var results = repo.Search("");

            Assert.Equal(2, results.Count); 
        }
    }
}