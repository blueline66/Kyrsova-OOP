using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient Clone()
        {
            return new Ingredient
            {
                Name = this.Name,
                Quantity = this.Quantity,
                Unit = this.Unit
            };
        }

        public override string ToString()
        {
            return $"{Name}: {Quantity:F2} {Unit}";
        }
    }
}
