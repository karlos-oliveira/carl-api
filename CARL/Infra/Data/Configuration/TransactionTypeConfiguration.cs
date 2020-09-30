
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
namespace Infra.Data.Configuration
{
    public class TransactionTypeConfiguration : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {
            builder.ToTable("TransactionType");

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            builder.HasKey(x => x.Id);
        }
    }
}
