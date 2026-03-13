using RecipeApp.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RecipeApp.Export
{
    public interface IShoppingListExporter
    {
        void Export(List<Ingredient> ingredients, string filePath);
    }

    public class TxtExporter : IShoppingListExporter
    {
        public void Export(List<Ingredient> ingredients, string filePath)
        {
            var lines = ingredients.Select(i => $"- {i.Name}: {i.Quantity:F2} {i.Unit}");
            File.WriteAllLines(filePath, lines);
        }
    }

    public class CsvExporter : IShoppingListExporter
    {
        public void Export(List<Ingredient> ingredients, string filePath)
        {
            var lines = new List<string> { "Назва;Кількість;Одиниця виміру" };

            lines.AddRange(ingredients.Select(i => $"{i.Name};{i.Quantity:F2};{i.Unit}"));

            File.WriteAllLines(filePath, lines, new UTF8Encoding(true));
        }
    }
}