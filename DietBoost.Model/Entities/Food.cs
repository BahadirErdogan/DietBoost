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
        private decimal _pieceCalorie;
        private decimal _portionCalorie;
        private decimal _gramCalorie;
        public string Name { get; set; }
        public decimal Calorie { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
        public decimal Protein { get; set; }
        public decimal PieceGram { get; set; }
        public decimal PortionGram { get; set; }

        public decimal PieceCalorie { get => _pieceCalorie; set => _pieceCalorie = (Calorie / 100) * PieceGram; }
        public decimal PortionCalorie { get => _portionCalorie; set => _portionCalorie = (Calorie / 100) * PortionGram; }
        public decimal GramCalorie { get => _gramCalorie; set => _gramCalorie = (Calorie / 100); }

        public string Image { get; set; }
        public bool IsActive { get; set; }

        public int CategoryID { get; set; }


        public virtual ICollection<MealDetail> MealDetails { get; set; }
        public virtual Category Categories { get; set; }
      
    }
}
