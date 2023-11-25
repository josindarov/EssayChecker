using EssayChecker.API.Models.Essays;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker
{
    public void ConfigureEssay(EntityTypeBuilder<Essay> builder)
    {
        builder.HasOne(essay => essay.Feedback)
            .WithOne(feedback => feedback.Essay);
    }
}