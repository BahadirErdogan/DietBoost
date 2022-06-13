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
            MealDetails = new HashSet<MealDetails>();
        }
        private decimal PieceCalorie;
        private decimal PortionCalorie;
        private decimal GramCalorie;
        public int FoodId { get; set; }
        public string Name { get; set; }
        public decimal Calorie { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
        public decimal Protein { get; set; }
        public decimal PieceGram { get; set; }
        public decimal PortionGram { get; set; }
        public decimal PieceCalorie1 { set{ value = (Calorie / 100) * PieceGram; }}
        public decimal PortionCalorie1 { set { value = (Calorie / 100) * PortionGram; } }
        public decimal GramCalorie1 { set { value = (Calorie / 100); } }
        public bool IsActive { get; set; }

        public int CategoryID { get; set; }


        public virtual ICollection<MealDetails> MealDetails { get; set; }
        public virtual Categories Categories { get; set; }

    }
}
