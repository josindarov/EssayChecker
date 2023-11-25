using EssayChecker.API.Brokers.StorageBroker;
using EssayChecker.API.Models.Feedbacks;

namespace EssayChecker.API.Services.Foundations.Feedbacks;

public class FeedbackService : IFeedbackService
{
    private readonly IStorageBroker storageBroker;

    public FeedbackService(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }
    
    public async ValueTask<Feedback> AddFeedbackAsync(Feedback feedback)
    {
        return await storageBroker.InsertFeedbackAsync(feedback);
    }

    public async ValueTask<Feedback> RetriveFeedbackByIdAsync(Guid id)
    {
        return await storageBroker.SelectFeedbackById(id);
    }

    public IQueryable<Feedback> RetriveAll()
    {
        return storageBroker.SelectAllFeedbacks();
    }
}