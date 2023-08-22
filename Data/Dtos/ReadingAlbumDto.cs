using AlbumApi.Models;


namespace AlbumApi.Data.Dtos
{
    public class ReadingAlbumDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Banda { get; set; }

        public ICollection<ReadingMusicaDto> Musicas { get; set; }
    }
}
