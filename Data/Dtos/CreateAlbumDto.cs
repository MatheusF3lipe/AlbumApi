
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AlbumApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumApi.Data.Dtos
{


    public class CreateAlbumDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public string? Banda { get; set; }
        [ForeignKey("Id")]
        public virtual IEnumerable<Musica>? Musicas { get; set; }
    }
}
