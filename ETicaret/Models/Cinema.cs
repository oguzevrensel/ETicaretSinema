using ETicaret.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ETicaret.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}