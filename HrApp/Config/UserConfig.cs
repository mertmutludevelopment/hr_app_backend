using HrApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HrApp.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Email="mert@gmail.com",
                    Fullname = "MERT MUTLU",
                    Department = "Mobile",
                    PhoneNumber= "5380329797",
                    BirthDay= 1,
                    BirthMonth=1,
                    BirthYear=2001,
                    Password="mert123"




                }

            );
        }
    }
}
