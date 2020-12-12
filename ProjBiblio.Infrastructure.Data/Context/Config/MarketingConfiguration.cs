using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjBiblio.Domain.Entities;

namespace ProjBiblio.Infrastructure.Data.Context.Config
{
    public class MarketingConfiguration: IEntityTypeConfiguration<Marketing>
    {
        public void Configure(EntityTypeBuilder<Marketing> builder)
        {
            builder.HasKey(p => p.MarketingID);
        }
    }
}