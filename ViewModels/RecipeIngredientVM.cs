using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.ViewModels
{
    public class RecipeIngredientVM
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string NameWithAmount { get { return Name + " (" + Amount + " g)"; } }

        public RecipeIngredientVM(int ingredientId, string name, decimal amount)
        {
            IngredientId = ingredientId;
            Name = name;
            Amount = amount;
        }
    }
}
