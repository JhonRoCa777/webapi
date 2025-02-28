using Microsoft.EntityFrameworkCore;
using webapi.Infrastructure.Models;

namespace webapi.Infrastructure.Seeds
{
    public class TareaSeed : IEntityTypeConfiguration<Tarea>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tarea> builder)
        {
            builder.HasData(
                new Tarea()
            );
        }
    }
}
