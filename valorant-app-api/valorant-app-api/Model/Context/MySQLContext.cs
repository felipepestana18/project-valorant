using Microsoft.EntityFrameworkCore;

namespace valorant_app_api.Model.Context
{
    public class SQLContext : DbContext
    {

        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Map> Maps { get; set; }

        public DbSet<Match> Matches { get; set; }
    }
}
