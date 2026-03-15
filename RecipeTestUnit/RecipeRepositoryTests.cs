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
        // №1
        [Fact]
        public void Search_ShouldReturnRecipe_WhenSearchingByName()
        {
            var repo = GetTestRepository();

            var results = repo.Search("Борщ");

            Assert.Single(results);
            Assert.Equal("Борщ", results[0].Name);
        }
        // №2
        [Fact]
        public void Search_ShouldReturnRecipe_WhenSearchingByIngredient()
        {
            var repo = GetTestRepository();

            var results = repo.Search("огірок");

            Assert.Single(results);
            Assert.Equal("Салат", results[0].Name);
        }
        // №3
        [Fact]
        public void Search_ShouldReturnAll_WhenQueryIsEmpty()
        {
            var repo = GetTestRepository();

            var results = repo.Search("");

            Assert.Equal(2, results.Count);
        }
        // №4
        [Fact]
        public void Search_ShouldReturnEmpty_WhenRecipeNotFound()
        {
            var repo = GetTestRepository();

            var results = repo.Search("Піцца");

            Assert.Empty(results);
        }
        // №5
        [Fact]
        public void AddRecipe_ShouldIncreaseRecipeCount()
        {
            var repo = GetTestRepository();

            repo.AddRecipe(new Recipe
            {
                Name = "Омлет",
                Ingredients = new List<Ingredient>
        {
            new Ingredient { Name = "Яйце" }
        }
            });

            var results = repo.Search("");

            Assert.Equal(3, results.Count);
        }
        // №6
        [Fact]
        public void Search_ShouldBeCaseInsensitive()
        {
            var repo = GetTestRepository();

            var results = repo.Search("борщ");

            Assert.Single(results);
        }
        // №7
        [Fact]
        public void Search_ShouldFindPartialName()
        {
            var repo = GetTestRepository();

            var results = repo.Search("орщ");

            Assert.Single(results);
        }
        // №8
        [Fact]
        public void Search_ShouldFindIngredientRegardlessOfCase()
        {
            var repo = GetTestRepository();

            var results = repo.Search("ПОМІДОР");

            Assert.Single(results);
        }
        // №9
        [Fact]
        public void GetAll_ShouldReturnAllRecipes()
        {
            var repo = GetTestRepository();

            var results = repo.Search("");

            Assert.True(results.Count >= 2);
        }
    }
}