﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.Model.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
