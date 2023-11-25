using EssayChecker.API.Models.Feedbacks;
using Microsoft.EntityFrameworkCore;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker : IStorageBroker
{
    public DbSet<Feedback> Feedbacks { get; set; }

    public async ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback) =>
        await InsertAsync<Feedback>(feedback);
    public IQueryable<Feedback> SelectAllFeedbacks() =>
        SelectAll<Feedback>();
    public async ValueTask<Feedback> SelectFeedbackById(Guid id) =>
        await SelectAsync<Feedback>(id);
}