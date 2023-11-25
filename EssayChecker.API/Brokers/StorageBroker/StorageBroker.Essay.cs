using EssayChecker.API.Models.Essays;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker : IStorageBroker
{
    public async ValueTask<Essay> InsertEssayAsync(Essay essay)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Essay> SelectAllEssays()
    {
        throw new NotImplementedException();
    }

    public async ValueTask<Essay> SelectEssayByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<Essay> DeleteEssayAsync(Essay essay)
    {
        throw new NotImplementedException();
    }
}