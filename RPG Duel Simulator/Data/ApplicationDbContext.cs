using Microsoft.EntityFrameworkCore;
using RPG_Duel_Simulator.Models;

namespace RPG_Duel_Simulator.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters { get; set; }
    }
}
