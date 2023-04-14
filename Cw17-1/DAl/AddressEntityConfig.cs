using Cw17_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace Cw17_1.DAl
{
    public class AddressEntityConfig : IEntityTypeConfiguration<Adrress>
    {
        public void Configure(EntityTypeBuilder<Adrress> builder)
        {
            builder.HasOne(e => e.user)
            .WithOne(e => e.Adrress)
            .HasForeignKey<Adrress>(e => e.userId)
            .IsRequired();
        }
    }
}
