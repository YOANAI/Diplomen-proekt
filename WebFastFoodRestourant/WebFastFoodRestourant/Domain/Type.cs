using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFastFoodRestaurantApp.Domain;

namespace WebFastFoodRestourant.Domain
{
    public class Type
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public virtual IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
