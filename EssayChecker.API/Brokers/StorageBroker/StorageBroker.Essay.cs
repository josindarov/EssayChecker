using EssayChecker.API.Models.Essays;
using Microsoft.EntityFrameworkCore;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker : IStorageBroker
{
    public DbSet<Essay> Essays { get; set; }

    public async ValueTask<Essay> InsertEssayAsync(Essay essay) =>
        await InsertAsync(essay);

    public IQueryable<Essay> SelectAllEssays() =>
         SelectAll<Essay>();

    public async ValueTask<Essay> SelectEssayByIdAsync(Guid id) =>
        await SelectAsync<Essay>(id);

    public async ValueTask<Essay> DeleteEssayAsync(Essay essay) =>
        await DeleteAsync<Essay>(essay);
}