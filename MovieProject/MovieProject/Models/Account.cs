using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieProject.Models
{
    public class Account
    {
        [Key] public int AccountId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public User? User { get; set; }
    }
}
