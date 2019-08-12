using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCard.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string RecipeIngredients { get; set; }
        public string RecipeInstructions { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
