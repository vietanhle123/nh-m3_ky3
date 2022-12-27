using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace MovieProject.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string? DirectorName { get; set; }
        public string? EngDirector { get; set; }
        public string ProfileImg { get; set; }

        public ICollection<Directing>? Directings { get; set; }
    }
}
