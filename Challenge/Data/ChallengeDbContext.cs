using Challenge.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Data
{
    public class ChallengeDbContext : DbContext
    {
        public ChallengeDbContext(DbContextOptions<ChallengeDbContext> options): base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}
