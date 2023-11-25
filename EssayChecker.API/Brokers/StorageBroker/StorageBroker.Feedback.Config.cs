using EssayChecker.API.Models.Feedbacks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker
{
    public void ConfigureFeedback(EntityTypeBuilder<Feedback> builder)
    {
        builder.HasOne(feedback => feedback.Essay)
            .WithOne(essay => essay.Feedback);
    }    
}