using DietBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTaslak.Entities
{
    public class Food : BaseEntity
    {
        public Food()
        {
            MealDetails = new HashSet<MealDetail>();
        }
        //private decimal _pieceCalorie;
        //private decimal _portionCalorie;
        //private decimal _gramCalorie;
        public string Name { get; set; }
        public decimal Calorie { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
        public decimal Protein { get; set; }
        public decimal PieceGram { get; set; }
        public decimal PortionGram { get; set; }

        //public decimal PieceCalorie { get { return _pieceCalorie; }  set { value= (Calorie / 100) * PieceGram; }  }
        //public decimal PortionCalorie { get { return _portionCalorie; }  set { value = (Calorie / 100) * PortionGram; } }
        //public decimal GramCalorie { get { return _gramCalorie; }  set { value = (Calorie / 100); } }
        public decimal PieceCalorie { get; set; }
        public decimal PortionCalorie { get; set; }
        public decimal GramCalorie { get; set; }

        public string Image { get; set; }
        public bool IsActive { get; set; }

        public int CategoryID { get; set; }


        public virtual ICollection<MealDetail> MealDetails { get; set; }
        public virtual Category Category { get; set; }
      
    }
}
