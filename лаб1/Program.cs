using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб1
{

public class Example
    {
        
        public class CategoriesOfMenu
        {
            public int CategoriesId { get; set; }
            public string Category { get; set; }
            public string Name { get; set; }

            public CategoriesOfMenu(int categoriesid, string category, string name)
            {
                this.CategoriesId = categoriesid;
                this.Category = category;
                this.Name = name;
            }

            public CategoriesOfMenu() { }

            public override string ToString()
            {
                return string.Format($"id:{this.CategoriesId};  category:{this.Category}; dish name:{this.Name} ");
            }

        }

        public class Ingredient
        {
            public int IngredientId { get; set; }
            public string IngredientName { get; set; }
            public int AmountOfCalories { get; set; }

            public Ingredient(int ingredientid, string ingredientname, int amountofcalories)
            {
                this.IngredientId = ingredientid;
                this.IngredientName = ingredientname;
                this.AmountOfCalories = amountofcalories;
            }
            public Ingredient() { }
            public override string ToString()
            {
                return string.Format($"id:{this.IngredientId};  name:{this.IngredientName}; amount of calories:{this.AmountOfCalories} ");
            }
        }

        public class Dish
        {
            public int DishId { get; set; }
            public string DishName { get; set; }
            public int IngredientId { get { return Ingredient.IngredientId; } }
            Ingredient Ingredient = new Ingredient();
            public int AmountOfIngredient { get; set; }


            public List<Dish> Dishes { get; set; }

            public Dish(int dishid, string dishname, int ingredientid, int amountofingredient)
            {
                this.DishId = dishid;
                this.DishName = dishname;
                Ingredient.IngredientId = ingredientid;
                this.AmountOfIngredient = amountofingredient;

            }
            public Dish() { }

            public override string ToString()
            {
                return string.Format($"id:{this.DishId};  dish name:{this.DishName} ingredient:{this.Ingredient.IngredientName} amount:{this.AmountOfIngredient} ");
            }
        }

        public class Menu
        {
            public int MenuId { get; set; }
            public int CategoryId { get { return categories.CategoriesId; } } 
            CategoriesOfMenu categories = new CategoriesOfMenu();
            public DateOnly Date { get; set; }
            Dish Dish = new Dish();
            public string Dishname { get { return Dish.DishName; } }
            public int Cost { get; set; }

            public Menu(int menuid, int categoryid, DateOnly date, string dishname, int cost)
            {
                this.MenuId = menuid;
                categories.CategoriesId = categoryid;
                this.Date = date;
                Dish.DishName = dishname;
                this.Cost = cost;
            }
            public Menu() { }

            public override string ToString()
            {
                return string.Format($"id:{this.MenuId}; catid:{categories.CategoriesId}; date:{this.Date}; dish name:{this.Dish.DishName} price:{Cost}");
            }

        }
    }
}

   

