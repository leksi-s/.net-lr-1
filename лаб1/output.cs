using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static лаб1.Example;
using static лаб1.Requests;

namespace лаб1
{
    
    public class Output
    {
        Data data = new Data();
        Requests requests = new Requests();
        private void output<T>(IEnumerable<T> q)
        {
            foreach (var item in q)
                Console.WriteLine(item);
        }

        public void SelectAll_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. вивід всіх значень у одній колекції:");
            Console.ResetColor();
            var q = requests.SelectAll(data.MenuList);
            output(q);
        }

        public void OneCategory_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2. вибір однієї категорії:");
            Console.ResetColor();
            var q = requests.OneCategory(data.CategoriesList);
            output(q);
        }

        public void ByGrowth_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3. сортування за одним зі значень:");
            Console.ResetColor();
            var q = requests.ByGrowth(data.IngredientsList);
            output(q);
        }

        public void LessThan200_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("4.вибір страв, що вартують менше за визначену суму:");
            Console.ResetColor();
            var q = requests.LessThan200(data.MenuList);
            output(q);
        }

        public void StartsWith_r_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("5. вибір страв, що починаються на r:");
            Console.ResetColor();
            var q = requests.StartsWith_r(data.CategoriesList);
            output(q);
        }

        public void SeveralSelections_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("6. вибір з кількома значеннями:");
            Console.ResetColor();
            var q = requests.SeveralSelections(data.DishesList);
            output(q);
        }

        public void UsingOfSkipWhile_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("7. пропуск деяких значенб за допомогою skipwhile:");
            Console.ResetColor();
            var q = requests.UsingOfSkipWhile(data.MenuList);
            output(q);
        }

        public void SelectionFromTwoLists_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("8. вибірка значень з двох таблиуь:");
            Console.ResetColor();
            var q = requests.SelectionFromTwoLists(data.MenuList, data.CategoriesList);
            output(q);
        }

        public void GroupCategories_Output(IEnumerable<IGrouping<string, CategoriesOfMenu>> groupedCategories)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("9. групуємо по значенням:");
            Console.ResetColor();
            foreach (var g in groupedCategories)
            {
                Console.WriteLine(g.Key);
                foreach (var category in g)
                {
                    Console.WriteLine(category);
                }
            }
        }

        public void InDifferentOrder_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("10. список у іншому порядку:");
            Console.ResetColor();
            var q = requests.InDifferentOrder(data.IngredientsList);
            output(q);
        }
        public void PriceForAllDishesInACategory_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("11. виведення двох стовпців таблиці за ознакою:");
            Console.ResetColor();
            var q = requests.PriceForAllDishesInACategory(data.MenuList);
            output(q);
        }

        public void UseOfConcat_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("12. об'єднання двох колекцій:");
            Console.ResetColor();
            var q = requests.UseOfConcat(data.CategoriesList, data.IngredientsList);
            output(q);
        }

        public void CategoriesSeparation_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("13. групування страв по категоріям:");
            Console.ResetColor();
            //var q = requests.CategoriesSeparation(data.CategoriesList);
            //output(q);
            var categoryGroups = requests.CategoriesSeparation(data.CategoriesList);
            foreach (var group in categoryGroups)
            {
                Console.WriteLine(group.Key);
                foreach (var q in group)
                {
                    Console.WriteLine(q);
                }
                Console.WriteLine();
            }
        }

        public void CategoriesUnion_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("14. зєднання двох колекцій:");
            Console.ResetColor();
            var q = requests.CategoriesUnion(data.CategoriesList, data.DishesList);
            output(q);
        }

        public void OneDishContains_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("15. отримання складових однієї страви:");
            Console.ResetColor();
            var q = requests.OneDishContains(data.DishesList, data.IngredientsList);
            output(q);
        }

        public void MenuOk_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("16. отримання меню з доповненою інформацією:");
            Console.ResetColor();
            var q = requests.MenuOk(data.MenuList, data.CategoriesList);
            output(q);
        }

        public void UseOfSum_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("17. застосування sum:");
            Console.ResetColor();
            var q = requests.UseOfSum(data.MenuList);
            Console.WriteLine(q);
        }

        public void LessCalories_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("18. застосування takewhile/ вивід інгредієнтів допоки кількість калорій не перевищує 350:");
            Console.ResetColor();
            var q = requests.LessCalories(data.IngredientsList);
            output(q);
        }

        public void Menu1_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("19. вивід унікальних страв:");
            Console.ResetColor();
            var q = requests.Menu1(data.MenuList);
            output(q);
        }

        public void Categories_Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("20. вибір перших 5 рядків за допомогою take:");
            Console.ResetColor();
            var q = requests.Categories(data.CategoriesList);
            output(q);
        }
    }

}
