using ETicaret.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ETicaret.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Adı Soyadı")]
        public string FullName { get; set; }

        [Display(Name = "Biyografi")]
        public string Bio { get; set; }

        public string ProfilePictureUrl { get; set; }

        public List<Movie> Movies { get; set; }
    }
}