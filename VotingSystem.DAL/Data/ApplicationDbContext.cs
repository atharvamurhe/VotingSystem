using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VotingSystem.DAL.Data.Models;

namespace VotingSystem.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
    }
}
