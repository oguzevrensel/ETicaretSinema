using ETicaret.Data.Base;
using ETicaret.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ETicaret.Data.ViewModels
{
    public class MovieVM : IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; } = "";

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

        [Display(Name = "Aktör Seçiniz")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Sinema Seçiniz")]
        public int CinemaId { get; set; }

        [Display(Name = "Productor Seçiniz")]
        public int ProducerId { get; set; }
    }
}