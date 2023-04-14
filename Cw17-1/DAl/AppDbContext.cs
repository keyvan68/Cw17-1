using Cw17_1.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Xml;

namespace Cw17_1.DAl
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfig());
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=CW17;Trusted_Connection=True;TrustServerCertificate=True;");
        //}
        public DbSet<User> Users {get; set;}

        public DbSet<Adrress> Adrresses { get; set; }
        //builder.Services.AddDbContext(option => option.UseSqlServer("Server =.; Database = dbJobMaktab; Trusted_Connection = True; TrustServerCertificate = True; "));
    }
}
