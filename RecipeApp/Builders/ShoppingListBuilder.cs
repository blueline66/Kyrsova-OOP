using RecipeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeApp.Builders
{
    public class ShoppingListBuilder
    {
        private readonly Dictionary<string, Ingredient> _items;

        public ShoppingListBuilder()
        {
            _items = new Dictionary<string, Ingredient>();
        }

        public ShoppingListBuilder AddRecipe(Recipe recipe, int targetPortions)
        {
            if (targetPortions <= 0 || recipe.DefaultPortions <= 0)
                return this;

            double multiplier = (double)targetPortions / recipe.DefaultPortions;

            foreach (var ing in recipe.Ingredients)
            {
                string key = $"{ing.Name.ToLowerInvariant()}_{ing.Unit.ToLowerInvariant()}";

                double calculatedQuantity = ing.Quantity * multiplier;

                if (_items.ContainsKey(key))
                {
                    _items[key].Quantity += calculatedQuantity;
                }
                else
                {
                    var newIng = ing.Clone();
                    newIng.Quantity = calculatedQuantity;
                    _items[key] = newIng;
                }
            }

            return this; 
        }

        public List<Ingredient> Build()
        {
            return _items.Values.ToList();
        }
    }
}
