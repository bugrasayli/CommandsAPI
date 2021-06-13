using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Data
{

    public class CommandContext : DbContext
    {
        public DbSet<Command> CommandsItems { get; set; }
        public CommandContext(DbContextOptions<CommandContext> options) : base(options)
        {

        }
    }
}
