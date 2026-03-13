using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeApp.Models
{
    public class Recipe
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }
        public int DefaultPortions { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public override string ToString()
        {
            return $"{Name} ({DefaultPortions} порц.)";
        }

        public Recipe Clone()
        {
            return new Recipe
            {
                Id = this.Id,
                Name = this.Name,
                DefaultPortions = this.DefaultPortions,
                Ingredients = this.Ingredients.Select(i => i.Clone()).ToList()
            };
        }
    }
}