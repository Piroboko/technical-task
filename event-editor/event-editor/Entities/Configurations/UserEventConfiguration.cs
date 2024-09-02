using event_editor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace event_editor.Entities.Configurations
{
    public class UserEventConfiguration : IEntityTypeConfiguration<UserEvent>
    {
        public void Configure(EntityTypeBuilder<UserEvent> builder)
        {
            builder.HasKey(ue => new { ue.EventId, ue.UserId });

            builder.HasOne(ue => ue.User)
                .WithMany(u => u.UserEvents)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ue => ue.Event)
                .WithMany(e => e.UserEvents)
                .HasForeignKey(ue => ue.EventId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
