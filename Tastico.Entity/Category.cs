using System.Collections.Generic;

namespace Tastico.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}