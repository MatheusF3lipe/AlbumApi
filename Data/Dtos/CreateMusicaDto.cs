using System.ComponentModel.DataAnnotations;

namespace AlbumApi.Data.Dtos
{
    public class CreateMusicaDto
    {
        [Required]
        public String Nome { get; set; }
        public int AlbumId { get; set; }
    }
}
