using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace MovieProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? EngTitle { get; set; }
        public string? Description { get; set; }
        public string? Age { get; set; }
        public int DurationMin { get; set; }
        public decimal Price { get; set; }
        public DateTime OpeningDate { get; set; }
        public string? Trailer { get; set; }
        public string MainImg { get; set; }
        public string? ThumbnailImg { get; set; }

        public ICollection<MovieCategory>? MovieCategories { get; set; }
        public ICollection<Casting>? Castings { get; set; }
        public ICollection<Directing>? Directings { get; set; }
        public TrailerContainer? TrailerContainer { get; set; }
        public ICollection<Rating>? Ratings { get; set; }
        public ICollection<Order>? Orders { get; set; }
        
    }
}
