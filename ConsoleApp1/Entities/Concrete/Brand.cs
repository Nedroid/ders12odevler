﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProjectCar.Entities
{
    public class Brand:IEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
