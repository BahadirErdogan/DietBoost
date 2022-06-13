using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTaslak.Entities
{
    public class Food
    {
        public Food()
        {
            MealDetails = new HashSet<MealDetail>();
        }
        private decimal _pieceCalorie;
        private decimal _portionCalorie;
        private decimal _gramCalorie;
        public int FoodId { get; set; }
        public string Name { get; set; }
        public decimal Calory { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
        public decimal Protein { get; set; }
        public decimal PieceGram { get; set; }
        public decimal PortionGram { get; set; }
        public decimal PieceCalorie { set{ value = (Calory / 100) * PieceGram; }}
        public decimal PortionCalorie { set { value = (Calory / 100) * PortionGram; } }
        public decimal GramCalorie { set { value = (Calory / 100); } }
        public bool IsActive { get; set; }

        public int CategoryID { get; set; }


        public virtual ICollection<MealDetail> MealDetails { get; set; }
        public virtual Category Categories { get; set; }

    }
}
