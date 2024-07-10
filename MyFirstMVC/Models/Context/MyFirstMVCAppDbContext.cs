using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstMVC.Models.Context.Entities;

namespace MyFirstMVC.Models.Context
{
    public class MyFirstMVCAppDbContext : IdentityDbContext<AppUsers>
    {
        public MyFirstMVCAppDbContext(
            DbContextOptions<MyFirstMVCAppDbContext> options
            ) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Race> Races { get; set; }

    }
}
