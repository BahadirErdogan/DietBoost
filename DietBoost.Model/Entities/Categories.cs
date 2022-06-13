using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTaslak.Entities
{
    public class Categories
    {
        public Categories()
        {
            Foods = new HashSet<Food>();
        }
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Food> Foods { get; set; }


    }
}
