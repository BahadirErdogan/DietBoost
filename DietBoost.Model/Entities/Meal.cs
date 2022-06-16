using DietBoost.Model.Entities;
using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTaslak.Entities
{
    public class Meal : BaseEntity
    {
        public Meal()
        {
            MealDetails = new HashSet<MealDetail>();
        }

        public MealType MealType { get; set; }
        public DateTime MealDate { get; set; }



        public int UserID { get; set; }

        public virtual ICollection<MealDetail> MealDetails { get; set; }
        public virtual User User { get; set; }


    }
}
