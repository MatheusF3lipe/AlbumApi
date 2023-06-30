using AlbumApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlbumApi.Data.Dtos
{
    public class UpdateAlbum
    {
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public string? Banda { get; set; }
        public virtual IEnumerable<Musica>? Musicas { get; set; }
    }
}
