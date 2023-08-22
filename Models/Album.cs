using System.ComponentModel.DataAnnotations;


namespace AlbumApi.Models
{


    public class Album
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Banda { get; set; }
        public virtual ICollection<Musica> Musicas { get; set; }
    }
}
