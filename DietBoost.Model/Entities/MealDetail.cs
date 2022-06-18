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

        private decimal _totalCalorie;
        public decimal TotalCalorie
        {
            get { return _totalCalorie; }
            set
            {
                if (PortionType == PortionType.Piece)
                {
                    _totalCalorie = Food.PieceCalorie * Quantity;
                }
                else if (PortionType == PortionType.Gram)
                {
                    _totalCalorie = Food.GramCalorie * Quantity;
                }
                else
                {
                    _totalCalorie = Food.PortionCalorie * Quantity;
                }
            }
        }

        public PortionType PortionType { get; set; }


        public virtual Meal Meal { get; set; }
        public virtual Food Food { get; set; }
        
    }

    
}
