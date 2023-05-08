using ETicaret.Data.Base;
using ETicaret.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaret.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Fiyat")]
        public double Price { get; set; }

        public string ImageUrl { get; set; }

        [Display(Name = "Gösterim Tarihi")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Son Gösterim Tarihi")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Tür")]
        public MovieCategory MovieCategory { get; set; }




        public List<Actor_Movie> Actors_Movies { get; set; }






        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }


        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }



    }
}