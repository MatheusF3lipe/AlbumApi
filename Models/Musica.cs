using System.ComponentModel.DataAnnotations;

namespace AlbumApi.Models
{
    public class Musica
    {
        [Key]
        public int Id { get; set; }
        public String Nome { get; set; }
    }
}
