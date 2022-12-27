using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieProject.Models
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }
        public string? VoteName { get; set; }
        public Rating? Rating { get; set; }
    }
}
