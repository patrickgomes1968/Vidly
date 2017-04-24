using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required][StringLength(100)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Display(Name = "Genre")]
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }
     }
}