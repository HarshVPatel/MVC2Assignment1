using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC2Assignment1.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        



        public Customer Customer { get; set; }
    }
}