using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlbumApi.Models
{
    public class Musica
    {

        [Key]
        [Required]
        public int Id { get; set; }
        public String Nome { get; set; }
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }
}
