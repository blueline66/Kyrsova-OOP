using System.Collections.Generic;
using System.Linq;
using Xunit;
using RecipeApp.Models;     
using RecipeApp.Builders;

namespace RecipeApp.Tests
{
    public class ShoppingListBuilderTests
    {
        [Fact]
        public void AddRecipe_ShouldMultiplyIngredients_WhenPortionsAreIncreased()
        {
            var recipe = new Recipe
            {
                Name = "Млинці",
                DefaultPortions = 2,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Молоко", Quantity = 500, Unit = "мл" },
                    new Ingredient { Name = "Борошно", Quantity = 200, Unit = "г" }
                }
            };
            var builder = new ShoppingListBuilder();

            builder.AddRecipe(recipe, 4);
            var result = builder.Build();

            Assert.Equal(2, result.Count); 
            Assert.Equal(1000, result.First(i => i.Name == "Молоко").Quantity);
            Assert.Equal(400, result.First(i => i.Name == "Борошно").Quantity);
        }

        [Fact]
        public void AddRecipe_ShouldMergeSameIngredients_FromDifferentRecipes()
        {
            var recipe1 = new Recipe
            {
                Name = "Торт",
                DefaultPortions = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Цукор", Quantity = 200, Unit = "г" },
                    new Ingredient { Name = "Яйце", Quantity = 2, Unit = "шт" }
                }
            };

            var recipe2 = new Recipe
            {
                Name = "Заварний крем",
                DefaultPortions = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Цукор", Quantity = 150, Unit = "г" },
                    new Ingredient { Name = "Яйце", Quantity = 3, Unit = "шт" },
                    new Ingredient { Name = "Ванілін", Quantity = 10, Unit = "г" }
                }
            };

            var builder = new ShoppingListBuilder();

            builder.AddRecipe(recipe1, 1).AddRecipe(recipe2, 1);
            var result = builder.Build();

            Assert.Equal(3, result.Count);
            Assert.Equal(350, result.First(i => i.Name == "Цукор").Quantity); 
            Assert.Equal(5, result.First(i => i.Name == "Яйце").Quantity);   
            Assert.Equal(10, result.First(i => i.Name == "Ванілін").Quantity);
        }

        [Fact]
        public void AddRecipe_ShouldIgnore_WhenPortionsAreZeroOrLess()
        {
            var recipe = new Recipe
            {
                Name = "Омлет",
                DefaultPortions = 1,
                Ingredients = new List<Ingredient> { new Ingredient { Name = "Яйце", Quantity = 2, Unit = "шт" } }
            };
            var builder = new ShoppingListBuilder();

            builder.AddRecipe(recipe, 0);
            builder.AddRecipe(recipe, -5);
            var result = builder.Build();

            Assert.Empty(result);
        }
    }
}