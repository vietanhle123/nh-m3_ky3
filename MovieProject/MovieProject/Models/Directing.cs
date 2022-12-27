using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieProject.Models
{
    public class Directing
    {   
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int DirectorId { get; set; }

        public Movie? Movie { get; set; }
        public Director? Director { get; set; }
    }
}
