using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlbumApi.Models
{
    public class Musica
    {

        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]
        public int AlbumId { get; set; }
        public virtual Album album { get; set; }
    }
}
