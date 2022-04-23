using Microsoft.AspNetCore.Mvc;
using RestoApp.DataContext;
using RestoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MealDbContext _context;

        public HomeController(MealDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var vm = new HomeViewModel();
            vm.Persons = _context.Persons.ToList();
            vm.Meals = _context.Meals.ToList();
            vm.Recipes = vm.Meals.Take(3).ToList();
            return View(vm);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Dishes()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
    }
}
