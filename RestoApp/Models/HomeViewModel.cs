using RestoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoApp.Models
{
    public class HomeViewModel
    {
        public int Counter { get; set; } = 0;
        public List<Person> Persons { get; set; }
        public List<Meal> Meals { get; set; }
        public List<Meal> Recipes { get; set; }
    }
}
