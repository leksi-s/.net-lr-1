using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using static лаб1.Example;

namespace лаб1
{

    public class Data : IData
    {
        public List<CategoriesOfMenu> CategoriesList = new List<CategoriesOfMenu>()
        {
            new CategoriesOfMenu(1, "meat dishes", "beef steak"),
            new CategoriesOfMenu(2, "vegan dishes", "vegetables on steam"),
            new CategoriesOfMenu(3, "soups", "cream soup with beans"),
            new CategoriesOfMenu(4, "cereals", "rice with vegetables"),
            new CategoriesOfMenu(2, "vegan dishes", "cream soup with beans"),
            new CategoriesOfMenu(2, "vegan dishes", "rice with vegetables"),
            new CategoriesOfMenu(5, "desserts", "ice cream with chocolate"),
        };

        public List<Ingredient> IngredientsList = new List<Ingredient>()
        {
            new Ingredient( 1, "rice", 220),
            new Ingredient( 2,"beef", 350),
            new Ingredient (3, "vegetables", 75),
            new Ingredient(4, "ice cream", 400),
            new Ingredient(5,"beans", 50),
            new Ingredient(6,"potato", 80),
            new Ingredient(7,"brocolli", 70),
            new Ingredient(8, "chocolate", 600)
        };

        public List<Dish> DishesList = new List<Dish>()
        {
            new Dish(1, "beef steak", 2, 250),
            new Dish(2, "vegetables on steam", 3, 300),
            new Dish(3, "rice with vegetables", 1, 150),
            new Dish(3, "rice with vegetables", 3, 100),
            new Dish(4,"cream soup with beans", 5, 200),
            new Dish(4, "cream soup with beans", 7, 65),
            new Dish(5, "ice cream with chocolate", 4, 200),
            new Dish(5, "ice cream with chocolate", 8, 50)
        };


        public List<Menu> MenuList = new List<Menu>()
        {
            new Menu(1, 1, new DateOnly(2023, 3, 12), "beef steak", 350),
            new Menu(2, 2, new DateOnly(2023, 3, 11), "vegetables on steam", 150),
            new Menu(3, 3, new DateOnly(2023, 3, 10), "cream soup with beans", 200),
            new Menu(4, 4, new DateOnly(2023, 3, 12), "rice with vegetables", 120),
            new Menu(5, 5, new DateOnly(2023, 3, 13), "ice cream with chocolate", 100),
            new Menu(6, 2, new DateOnly(2023, 3, 12), "rice with vegetables", 120),
            new Menu(7, 2, new DateOnly(2023, 3, 10), "cream soup with beans", 200),
        };

        List<CategoriesOfMenu> IData.CategoriesList { get; }
        List<Ingredient> IData.IngredientsList { get; }
        List<Dish> IData.DishesList { get; }
        List<Menu> IData.MenuList { get; }
    }
}