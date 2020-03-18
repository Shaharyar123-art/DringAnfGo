using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DringsAndGo.Data.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String LongDescription { get; set; }
        public Decimal Price { get; set; }
        public String ImageUrl { get; set; }
        public String ImageThumbnailUrl { get; set; }
        public bool IsPreferredDrink { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual  Category Category { get; set; }
        public string ShortDescription { get; internal set; }
    }
}
