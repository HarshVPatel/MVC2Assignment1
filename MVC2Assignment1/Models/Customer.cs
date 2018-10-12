using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2Assignment1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmailService Email { get; set; }
    }
}