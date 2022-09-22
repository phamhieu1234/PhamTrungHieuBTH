using Microsoft.EntityFrameworkCore;

public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<PhamTrungHieuBTH.Models.Movie> Movie { get; set; } = default!;
    }
