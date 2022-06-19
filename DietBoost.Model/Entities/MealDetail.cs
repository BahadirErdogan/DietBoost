using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTaslak.Entities
{
    public class MealDetail
    {
        
        public int MealID { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }

        
        public decimal TotalCalorie { get; set; }
       

        public PortionType PortionType { get; set; }


        public virtual Meal Meal { get; set; }
        public virtual Food Food { get; set; }
        
    }

    
}
