﻿using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTaslak.Entities
{
    public class Meal
    {
        public Meal()
        {
            MealDetails = new HashSet<MealDetails>();
        }
        public int MealID { get; set; }
        public string Name { get; set;}
        public DateTime Date { get; set; }
        public MealType MealType { get; set; }

        public int UserID { get; set; }

        public virtual ICollection<MealDetails> MealDetails { get; set; }
        public virtual User User { get; set; }


    }
}
