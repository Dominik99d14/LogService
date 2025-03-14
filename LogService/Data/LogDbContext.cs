using Microsoft.EntityFrameworkCore;

namespace LogService.Data
{
    public class LogDbContext : DbContext
    {
        public LogDbContext(DbContextOptions<LogDbContext> options) : base(options) { }

        public DbSet<LogEntry> LogEntries { get; set; }
    }
}
