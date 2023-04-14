using Cw17_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace Cw17_1.DAl
{
    public class UserEntityConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Members","dbo");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.FullName).HasMaxLength(50).IsRequired();
            builder.HasOne(e => e.Adrress).WithOne(e=>e.user).HasForeignKey<Adrress>(e => e.userId);
            
        //    modelBuilder.Entity<Blog>()
        //    .HasOne(e => e.Header)
        //.WithOne(e => e.Blog)
        //.HasForeignKey<BlogHeader>(e => e.BlogId)
        //.IsRequired();

        }
    }
}
