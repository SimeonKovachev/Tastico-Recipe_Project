using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tastico.Entity
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public int CuisineId { get; set; }
        public virtual Cuisine Cuisine { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int DifficultyLevelId { get; set; }
        public virtual DifficultyLevel DifficultyLevel { get; set; }


        public int Portions { get; set; }
        public int TimeForCreation { get; set; }
        public int TimeForCooking { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        
        
       
    }
}
