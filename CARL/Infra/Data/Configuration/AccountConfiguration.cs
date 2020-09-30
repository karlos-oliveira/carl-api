
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
namespace Infra.Data.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.IsCard);
            builder.Property(x => x.DueDay);
            builder.Property(x => x.CloseDay);
            builder.Property(x => x.UserId).IsRequired();

            builder.HasKey(x => x.Id);
        }
    }
}
