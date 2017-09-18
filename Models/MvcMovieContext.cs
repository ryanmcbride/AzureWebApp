using Microsoft.EntityFrameworkCore;

namespace AzureWebApp.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<AzureWebApp.Models.Movie> Movie { get; set; }
    }
}