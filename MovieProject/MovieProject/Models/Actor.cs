using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace MovieProject.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string? ActorName { get; set; }
        public string? EngActor { get; set; }
        public string ProfileImg { get; set; }
        public ICollection<Casting>? Castings { get; set; }
    }
}
