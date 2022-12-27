using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieProject.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public decimal Price { get; set; }
        public Movie? Movie { get; set; }
        public User? User { get; set; }
    }
}
