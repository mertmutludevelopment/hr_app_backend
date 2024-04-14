using HrApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HrApp.Config
{
    public class EventConfig : IEntityTypeConfiguration<Event>
    {

        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasData(
                new Event
                {
                    Id = 1,
                    EventName = "Football Match",
                    EventLocation = "Bursaspor training complex",
                    EventDay = "20.01.2024",
                    EventTime = "18.00",
                    EventDescription = "Football match between teams",
                   
                }

            );
        }

       
    }
}
