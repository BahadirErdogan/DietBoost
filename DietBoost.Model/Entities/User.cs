using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTaslak.Entities
{
    public class User
    {
        public User()
        {
            Meals = new HashSet<Meal>();
        }

        private int age;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public int Age 
        {
            get { return age; }
            set
            {
                value = DateTime.Now.Year - BirthDate.Year;
            }
        }
        public string Phone { get; set; }
        [MinLength(6)]
        public string Password { get; set; }
        public decimal Weight { get; set; }
        public decimal WeightGoal { get; set; }
        public decimal Length { get; set; }
        public UserType UserType { get; set; }
        public bool IsActive { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public virtual ICollection<Meal> Meals { get; set; }

    }
}
