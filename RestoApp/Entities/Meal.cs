using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoApp.Entities
{
    public class Meal
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Composition { get; set; }
        public float Price { get; set; }
    }
}
