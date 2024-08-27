using Microsoft.EntityFrameworkCore;

namespace HGamesAPI.Models
{
    public class HGames_Context: DbContext
    {

        public HGames_Context(DbContextOptions<HGames_Context>options)
            :base(options)
        { }

        public DbSet<HGames_Information> HGames_Information { get; set; }
    }
}
