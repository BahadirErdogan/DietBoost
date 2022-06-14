using DietBoost.Model.Entities;
using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTaslak.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Meals = new HashSet<Meal>();
        }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }

        private int _age;

        public int Age 
        {
            get { return _age; }
            set
            {
                _age = DateTime.Now.Year - BirthDate.Year;
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
