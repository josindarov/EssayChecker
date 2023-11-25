using EssayChecker.API.Models.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker
{
    public void ConfigureUser(EntityTypeBuilder<User> builder)
    {
        builder.HasMany(user => user.Essays)
            .WithOne(essay => essay.User)
            .HasForeignKey(essay => essay.UserId);
    }
}