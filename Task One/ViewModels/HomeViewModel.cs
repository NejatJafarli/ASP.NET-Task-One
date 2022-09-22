using System.Collections.Generic;
using Task_One.Models;

namespace Task_One.ViewModels
{
    public class HomeViewModel
    {
        public List<Drinks> Drinks { get; set; }
        public List<HotMeals> HotMeals { get; set; }
        public List<FastFood> FastFoods { get; set; }
    }
}
