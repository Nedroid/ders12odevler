﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public int UserID { get; set; }
        public string CompanyName { get; set; }
    }
}
