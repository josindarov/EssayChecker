using EssayChecker.API.Brokers.StorageBroker;
using EssayChecker.API.Models.Essays;

namespace EssayChecker.API.Services.Foundations.Essays;

public class EssayService : IEssayService
{
    private readonly IStorageBroker storageBroker;

    public EssayService(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }
    
    public async ValueTask<Essay> AddEssayAsync(Essay essay)
    {
        return await storageBroker.InsertEssayAsync(essay);
    }

    public async ValueTask<Essay> RetriveEssayByIdAsync(Guid id)
    {
        return await storageBroker.SelectEssayByIdAsync(id);
    }

    public IQueryable<Essay> RetriveAllEssay()
    {
        return storageBroker.SelectAllEssays();
    }

    public async ValueTask<Essay> RemoveEssayAsync(Essay essay)
    {
        return await storageBroker.DeleteEssayAsync(essay);
    }
}