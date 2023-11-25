using EssayChecker.API.Models.Feedbacks;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial interface IStorageBroker
{
    ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback);
    IQueryable<Feedback> SelectAllFeedbacks();
    ValueTask<Feedback> SelectFeedbackById(Guid id);
}