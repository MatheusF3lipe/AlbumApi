using System.ComponentModel.DataAnnotations;

namespace AlbumApi.Data.Dtos
{
    public class CreateMusicaDto
    {
        [Required]
        public String Nome { get; set; }
        [Required]
        public int AlbumId { get; set; }
    }
}
