using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace MovieProject.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public int AccountId { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<Rating>? Ratings { get; set; }
        public Account? Account { get; set; }
    }
}
