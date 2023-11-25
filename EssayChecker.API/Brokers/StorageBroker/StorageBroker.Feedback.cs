using EssayChecker.API.Models.Feedbacks;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker : IStorageBroker
{
    public async ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Feedback> SelectAllFeedbacks()
    {
        throw new NotImplementedException();
    }

    public async ValueTask<Feedback> SelectFeedbackById(Guid id)
    {
        throw new NotImplementedException();
    }
}