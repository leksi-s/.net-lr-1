using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static лаб1.Example;
using static лаб1.Data;



namespace лаб1
{
    public class Requests
    {
        private readonly IData data;
        public Requests(Data data) { this.data = data; }
        public Requests()
        {
        }

        public IEnumerable<Menu> SelectAll(IEnumerable<Menu> menu)//1. виводимо всі значення з колекції
        {
            return from all in menu
                   select all;
        }
        public IEnumerable<CategoriesOfMenu> OneCategory(IEnumerable<CategoriesOfMenu> categories)//2. вибираємо одну категорію
        {
            return from category in categories
                   where category.Category.Equals("vegan dishes")
                   select category;
        }



        public IEnumerable<Ingredient> ByGrowth(IEnumerable<Ingredient> ingredients)//3. сортуємо за одним зі значень
        {
            return ingredients.OrderBy(i=>i.AmountOfCalories);
        }

        public IEnumerable<Menu> LessThan200(IEnumerable<Menu> menus)//4.вибір страв, що вартують менше за визначену суму
        {
            return from price in menus
                   where price.Cost <= 200
                   select price;
        }

        public IEnumerable<CategoriesOfMenu> StartsWith_r(IEnumerable<CategoriesOfMenu> menu)//5. вибір страв, що починаються на r
        {
            return from startswithr in menu
                                       where startswithr.Name.StartsWith("r")
                                       select startswithr;
        }

        public IEnumerable<Dish> SeveralSelections(IEnumerable<Dish> dish)//6. вибір з кількома значеннями
        {
            return from sevsel in dish
                   where sevsel.DishId > 1 && (sevsel.AmountOfIngredient == 200 || sevsel.AmountOfIngredient == 50)
                         select sevsel;
        }

        public IEnumerable<Menu> UsingOfSkipWhile(IEnumerable<Menu> menu)//7. пропуск деяких значенб
        {
            return menu.SkipWhile(skw => skw.Cost > 250);
        }

        public IEnumerable<object> SelectionFromTwoLists(IEnumerable<Menu> menu, IEnumerable<CategoriesOfMenu> category)// 8. вибірка значень з двох колекцій
        {
            return from m in menu
                   join c in category on m.CategoryId equals c.CategoriesId 
                   select new { m.CategoryId, c.Category, c.Name };
                   }

        public IEnumerable<IGrouping<string, CategoriesOfMenu>> GroupCategories(IEnumerable<CategoriesOfMenu> categories)// 9. групуємо по значенням
        {
            return from c in categories
                   group c by c.Category into groupedCategories
                   select groupedCategories;
        }

        public IEnumerable<Ingredient> InDifferentOrder(IEnumerable<Ingredient> ingredients)// 10. список у іншому порядку
        {
            return ingredients.Reverse();
        }

        public IEnumerable<object> PriceForAllDishesInACategory(IEnumerable<Menu> menu)// 11. виведення двох стовпців таблиці за ознакою
        {
            return from m in menu
                   where m.CategoryId == 3
                   select new { m.CategoryId, m.Cost };

        }
        public IEnumerable<object> UseOfConcat(IEnumerable<CategoriesOfMenu> categories, IEnumerable<Ingredient> ingredients)// 12. об'єднання двох колекцій
        {
            var categoriesObj = categories.Cast<object>();
            var ingredientsObj = ingredients.Cast<object>();

            return ingredientsObj.Concat(categoriesObj).ToList();
        }

        public ILookup<char, string> CategoriesSeparation(IEnumerable<CategoriesOfMenu> categories)//13. групування страв по категоріям
        { 
            var q=categories.ToLookup(c=>c.Name[0],
             c => c.Name);
            return q;
        }

        public IEnumerable<object> CategoriesUnion(IEnumerable<CategoriesOfMenu> categories, IEnumerable<Dish> dish)//14. зєднання двох колекцій
        {
            var query = from c in categories
                        join d in dish on c.Name equals d.DishName
                        select new
                        { c.Category, c.Name, d.AmountOfIngredient };

            return query.ToList();
        }

            public IEnumerable<object> OneDishContains(IEnumerable<Dish> dish, IEnumerable<Ingredient> ingredient)//15. отримання складових однієї страви
            {
            var query = from d in dish
                        where d.DishId == 3
                        join i in ingredient on d.IngredientId equals i.IngredientId
                        select new {d.DishName, i.IngredientName};
            return query.ToList();
        }

        public IEnumerable<object> MenuOk(IEnumerable<Menu> menu, IEnumerable<CategoriesOfMenu> categories)//16. отримання меню з доповненою інформацією
        {
            var query= from m in menu
                   join c in categories on m.CategoryId equals c.CategoriesId
                   select new { c.Category, m.Date, m.Dishname, m.Cost };
            return query.ToList();
        }

        public int UseOfSum(IEnumerable<Menu> menu)//17. застосування sum
        {
           return menu.Sum(m => m.Cost);
        }

        public IEnumerable<Ingredient> LessCalories(IEnumerable<Ingredient> ingredients)//18. застосування takewhile/ ивід інгредієнтів допоки кількість калорій не перевищує 300
        {
            return ingredients.TakeWhile(i => i.AmountOfCalories <= 350);
        }
        public IEnumerable<object> Menu1(IEnumerable<Menu> menus)//19. вивід унікальних страв
        {
            var q = menus.Select(m => m.Dishname).Distinct();
            return q.ToList();
        }
        public IEnumerable<object> Categories(IEnumerable<CategoriesOfMenu> categories)//20. вибір перших 5 рядків
        {
            var q= categories.Take(5);
            return q.ToList();
        }
    } }