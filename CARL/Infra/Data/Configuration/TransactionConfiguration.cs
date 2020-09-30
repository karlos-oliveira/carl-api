
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
namespace Infra.Data.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description);
            builder.Property(x => x.PaymentDate);
            builder.Property(x => x.PlannedDate);
            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.CategoryId);
            builder.Property(x => x.TransactionTypeId).IsRequired();

            builder.HasKey(x => x.Id);
        }
    }
}
