using System;
namespace MyFilmMVCV1.Models
{
    public class CartItem
    {
        public int FilmID { get; set; }

        public string FilmTitle { get; set; }

        public int OrderQuantity { get; set; }

        public decimal FilmPrice { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
