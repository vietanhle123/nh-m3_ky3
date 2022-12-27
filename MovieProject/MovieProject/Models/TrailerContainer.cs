using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace MovieProject.Models
{
    public class TrailerContainer
    {
        [Key]
        public int MovieId { get; set; }
        public string? PostingImg { get; set; }
        public Movie? Movie { get; set; }
    }
}
