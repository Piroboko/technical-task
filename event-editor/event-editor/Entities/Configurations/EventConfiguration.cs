using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace event_editor.Entities.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(60).IsRequired();
            builder.Property(e => e.DateTime).IsRequired();
            builder.Property(e => e.CreatorId).IsRequired();
        }
    }
}
