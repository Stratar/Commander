using Commander.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Commander.Data
{
    public class CommanderContext: DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options): base(options)
        {
            
        }
        
        public DbSet<Command> Commands { get; set; }
    }
}