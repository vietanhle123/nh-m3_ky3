using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieProject.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public int VoteId { get; set; }
        public string? Comment { get; set; }
        public Movie? Movie { get; set; }
        public User? User { get; set; }
        public Vote? Vote { get; set; }
    }
}
