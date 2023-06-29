using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlbumApi.Models
{
    public class Musica
    {

        [Key]
        public int IdMusica { get; set; }
        public String Nome { get; set; }
        [ForeignKey("Id")]
        public int AlbumId { get; set; }
    }
}
