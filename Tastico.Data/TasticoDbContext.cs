using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tastico.Entity;

namespace Tastico.Data
{
    public class TasticoDbContext : DbContext
    {
        public TasticoDbContext() : base("TasticoConnectionString") 
        {
        }
        public static TasticoDbContext Create()
        {
            return new TasticoDbContext();
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<DifficultyLevel> DifficultyLevels { get; set; }

    }
}
