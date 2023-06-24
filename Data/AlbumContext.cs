using AlbumApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumApi.Data
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> opts) : base(opts)
        {

        }
        public DbSet<Album> album { get; set; }

    }
}
