using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace mvc_webapp.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(maximumLength: 60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(maximumLength: 30)]
        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 100)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(maximumLength: 5)]
        public string Rating { get; set; }
    }

    public class MovieContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}