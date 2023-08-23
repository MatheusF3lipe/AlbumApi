namespace AlbumApi.Data.Dtos
{
    public class ReadingMusicaDto
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public ReadNomeAlbum Album { get; set; }
    }
}
