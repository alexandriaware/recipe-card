using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using RecipeCard.Models;

namespace RecipeCard.Database
{
    public class RecipeRepository
    {
        private string _recipeDb = ConfigurationManager.AppSettings["RecipeDb"];
    }
}
