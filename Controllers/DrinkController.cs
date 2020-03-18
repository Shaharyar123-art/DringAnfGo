using DringsAndGo.Data.Interfaces;
using DringsAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DringsAndGo.Controllers
{
    public class DrinkController:Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
       

        }
        public ViewResult List()
        {
            ViewBag.Name = "Dot net How?";
            
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks= _drinkRepository.Drinks;
            vm.CurrentCategory = "DrinkCategory"; 
            return View(vm);
             

        }
    }
}
