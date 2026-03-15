using System.Collections.Generic;
using System.Linq;
using Xunit;
using RecipeApp.Models;     
using RecipeApp.Builders;

namespace RecipeApp.Tests
{
    public class ShoppingListBuilderTests
    {
        // №10
        [Fact]
        public void AddRecipe_ShouldMultiplyIngredients_WhenPortionsAreIncreased()
        {
            var recipe = new Recipe
            {
                Name = "������",
                DefaultPortions = 2,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "������", Quantity = 500, Unit = "��" },
                    new Ingredient { Name = "�������", Quantity = 200, Unit = "�" }
                }
            };
            var builder = new ShoppingListBuilder();

            builder.AddRecipe(recipe, 4);
            var result = builder.Build();

            Assert.Equal(2, result.Count);
            Assert.Equal(1000, result.First(i => i.Name == "������").Quantity);
            Assert.Equal(400, result.First(i => i.Name == "�������").Quantity);
        }
        // №11
        [Fact]
        public void AddRecipe_ShouldMergeSameIngredients_FromDifferentRecipes()
        {
            var recipe1 = new Recipe
            {
                Name = "����",
                DefaultPortions = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "�����", Quantity = 200, Unit = "�" },
                    new Ingredient { Name = "����", Quantity = 2, Unit = "��" }
                }
            };

            var recipe2 = new Recipe
            {
                Name = "�������� ����",
                DefaultPortions = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "�����", Quantity = 150, Unit = "�" },
                    new Ingredient { Name = "����", Quantity = 3, Unit = "��" },
                    new Ingredient { Name = "������", Quantity = 10, Unit = "�" }
                }
            };

            var builder = new ShoppingListBuilder();

            builder.AddRecipe(recipe1, 1).AddRecipe(recipe2, 1);
            var result = builder.Build();

            Assert.Equal(3, result.Count);
            Assert.Equal(350, result.First(i => i.Name == "�����").Quantity);
            Assert.Equal(5, result.First(i => i.Name == "����").Quantity);
            Assert.Equal(10, result.First(i => i.Name == "������").Quantity);
        }
        // №12
        [Fact]
        public void AddRecipe_ShouldIgnore_WhenPortionsAreZeroOrLess()
        {
            var recipe = new Recipe
            {
                Name = "�����",
                DefaultPortions = 1,
                Ingredients = new List<Ingredient> { new Ingredient { Name = "����", Quantity = 2, Unit = "��" } }
            };
            var builder = new ShoppingListBuilder();

            builder.AddRecipe(recipe, 0);
            builder.AddRecipe(recipe, -5);
            var result = builder.Build();

            Assert.Empty(result);
        }
        // №13
        [Fact]
        public void BuildShoppingList_NoRecipes_ReturnsEmpty()
        {
            var builder = new ShoppingListBuilder();

            var list = builder.Build();

            Assert.Empty(list);
        }
        // №14
        [Fact]
        public void BuildShoppingList_SingleRecipe()
        {
            var builder = new ShoppingListBuilder();

            var recipe = new Recipe
            {
                Name = "Омлет",
                DefaultPortions = 1,
                Ingredients = new List<Ingredient>
        {
            new Ingredient { Name="Eggs", Quantity=2, Unit="pcs" }
        }
            };

            builder.AddRecipe(recipe, 1);

            var list = builder.Build();

            Assert.Single(list);
        }
    }
}