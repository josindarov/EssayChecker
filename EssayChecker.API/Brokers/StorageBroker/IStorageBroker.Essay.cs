using EssayChecker.API.Models.Essays;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial interface IStorageBroker
{
    ValueTask<Essay> InsertEssayAsync(Essay essay);
    IQueryable<Essay> SelectAllEssays();
    ValueTask<Essay> SelectEssayByIdAsync(Guid id);
    ValueTask<Essay> DeleteEssayAsync(Essay essay);
}