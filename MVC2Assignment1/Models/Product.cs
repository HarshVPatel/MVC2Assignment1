﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2Assignment1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ICollection<Customer> Customer { get; set; }

    }
}