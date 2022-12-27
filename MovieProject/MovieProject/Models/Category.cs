using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }

        public ICollection<MovieCategory>? MovieCategories { get; set; }
    }
}
