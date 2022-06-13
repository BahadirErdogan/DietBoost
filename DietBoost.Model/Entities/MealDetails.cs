using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTaslak.Entities
{
    public class MealDetails
    {
        public int MealID { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }
        public decimal Portion { get; set; }

        public virtual Meal Meal { get; set; }
        public virtual Food Food { get; set; }
    }
}
