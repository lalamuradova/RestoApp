using Microsoft.EntityFrameworkCore;
using RestoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoApp.DataContext
{
    public class MealDbContext:DbContext
    {
        public MealDbContext(DbContextOptions<MealDbContext> options) : base(options)
        {

        }

        public DbSet<Meal> Meals { get; set; }
        public DbSet<Person> Persons { get; set; }
        
    }
}
