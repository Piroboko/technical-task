using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace event_editor.Models.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(60).IsRequired();
            builder.Property(e => e.DateTime).IsRequired();

            builder.HasOne(e => e.User)
                .WithMany(u => u.Events)
                .HasForeignKey(e => e.UserId);
        }
    }
}
