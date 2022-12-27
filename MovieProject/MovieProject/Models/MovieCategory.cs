using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieProject.Models
{
    public class MovieCategory
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CategoryId { get; set; }
        public Movie? Movie { get; set; }
        public Category? Category { get; set; }
    }
}
