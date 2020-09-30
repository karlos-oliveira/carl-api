
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
namespace Infra.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.ParentId);
            builder.Property(x => x.Level).IsRequired();
            builder.Property(x => x.TransactionTypeId);
            builder.Property(x => x.UserId);

            builder.HasKey(x => x.Id);
        }
    }
}
