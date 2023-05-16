using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using лаб1;
using static лаб1.Example;

namespace лаб1
{
    internal class mainclass
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            Requests requests = new Requests(data);
            Output output = new Output();
            output.SelectAll_Output();//1
            output.OneCategory_Output();//2
            output.ByGrowth_Output();//3 
            output.LessThan200_Output();//4
            output.StartsWith_r_Output();//5
            output.SeveralSelections_Output();//6
            output.UsingOfSkipWhile_Output();//7
            output.SelectionFromTwoLists_Output();//8 ??
            var groupedCategories = requests.GroupCategories(data.CategoriesList);
            output.GroupCategories_Output(groupedCategories);//9
            output.InDifferentOrder_Output();//10
            output.PriceForAllDishesInACategory_Output();//11 
            output.UseOfConcat_Output();//12
            output.CategoriesSeparation_Output();//13
            output.CategoriesUnion_Output();//14
            output.OneDishContains_Output();//15 ??
            output.MenuOk_Output();//16 
            output.UseOfSum_Output();//17
            output.LessCalories_Output();//18
            output.Menu1_Output();//19 
            output.Categories_Output();//20 
          
           
        }
    }
}
