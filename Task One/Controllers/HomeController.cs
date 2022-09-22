using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Task_One.Models;
using Task_One.ViewModels;

namespace Task_One.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }
        public IActionResult Drinks()
        {

            //create fastfood list
         
            List<Drinks> DrinksList = new List<Drinks>
            {
                new Drinks
            {
                Id = 1,
                Name="Fanta",
                Price="1.00",
                Description="Mandalinali Fanta"
            },
                new Drinks
            {
                Id = 2,
                Name = "Kola",
                Price = "1.20",
                Description = "coca cola"
            }
            };


            return View(DrinksList);
        }
        public IActionResult Index()
        {

    
            List<FastFood> fastFoodList = new List<FastFood> { new FastFood
            {
                Id = 1,
                Name = "Cheeseburger",
                Price = "6.00",
                Description = "2 Etli Cheeseburger"
            },new FastFood
            {
                Id = 2,
                Name = "Hamburger",
                Price = "5.00",
                Description = "2 Etli Hamburger"
            }
             };
           
            List<Drinks> DrinksList = new List<Drinks>
            {
                new Drinks
            {
                Id = 1,
                Name="Fanta",
                Price="1.00",
                Description="Mandalinali Fanta"
            },
                new Drinks
            {
                Id = 2,
                Name = "Kola",
                Price = "1.20",
                Description = "coca cola"
            }
            };

           List<HotMeals> HotMealsList=new List<HotMeals>
           {
               new HotMeals
               {
                     Id = 1,
                     Name = "Fresh Pear"
                },
               new HotMeals
                {
                    Id = 2,
                    Name = "Fresh Apple"
                },
                 new HotMeals
               {
                     Id = 3,
                     Name = "Seasoned Rice"
                }
               };


            //create viewmodel
            HomeViewModel vm = new HomeViewModel
            {
                Drinks = DrinksList,
                FastFoods = fastFoodList,
                HotMeals=HotMealsList
            };
            return View(vm);
        }
        public IActionResult HotMeals()
        {
            List<HotMeals> HotMealsList = new List<HotMeals>
           {
               new HotMeals
               {
                     Id = 1,
                     Name = "Fresh Pear"
                },
               new HotMeals
                {
                    Id = 2,
                    Name = "Fresh Apple"
                },
                 new HotMeals
               {
                     Id = 3,
                     Name = "Seasoned Rice"
                }
               };


            return View(HotMealsList);
        }
        public IActionResult FastFoods()
        {
            List<FastFood> fastFoodList = new List<FastFood> { new FastFood
            {
                Id = 1,
                Name = "Cheeseburger",
                Price = "6.00",
                Description = "2 Etli Cheeseburger"
            },new FastFood
            {
                Id = 2,
                Name = "Hamburger",
                Price = "5.00",
                Description = "2 Etli Hamburger"
            }
             };
            return View(fastFoodList);
        }
    }
}
