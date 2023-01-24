using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Recepie
    {
        public string name;

        protected List<Ingredient> ingredientsToGet = new List<Ingredient>();
        protected List<Ingredient> filledIngredients = new List<Ingredient>();

        public bool Interact(Ingredient ing)
        {
            for (int i = 0; i < ingredientsToGet.Count; i++)
            {
                if (ingredientsToGet[i].Name == ing.Name)
                {
                    filledIngredients.Add(ing);
                    ingredientsToGet.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
