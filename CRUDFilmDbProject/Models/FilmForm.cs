using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CRUDFilmDbProject.Models
{
    public class FilmForm

    {
        [Key]
        public int FilmID { get; set; }

        [Required(ErrorMessage = "Don't make us guess.  What film are we talking about?")]
        public string FilmTitle { get; set; }

        [Required]
        public string FilmCertificate { get; set; }

        public string FilmDescription { get; set; }

        public string FilmImage {  get; set;}

        public decimal FilmPrice { get; set; }

        public int Stars { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }

}