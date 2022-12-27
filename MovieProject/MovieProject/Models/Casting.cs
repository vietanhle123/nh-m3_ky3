using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieProject.Models
{
    public class Casting
    {   
        public int CastingId { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public Movie? Movie { get; set; }
        public Actor? Actor { get; set; }
        public string? Cast { get; set; }
    }
}
