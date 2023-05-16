using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static лаб1.Example;
using static лаб1.Data;


namespace лаб1
{
   public interface IData
    {
        List<CategoriesOfMenu> CategoriesList { get; }
        List<Ingredient> IngredientsList { get; }
        List<Dish> DishesList { get; }
        List<Menu> MenuList { get; }
    }
}