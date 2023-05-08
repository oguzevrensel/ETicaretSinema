using ETicaret.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ETicaret.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Resim"), Required(ErrorMessage = "Profil resmi zorunludur")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Ad Soyad resmi zorunludur")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ad soyad bilgisi minimum 3 maksimum 50 karakter olmalıdır.")]

        public string FullName { get; set; }

        [Display(Name = "Biyografi"), Required(ErrorMessage = "Biyografi bilgisi zorunludur")]
        public string Bio { get; set; }


        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}