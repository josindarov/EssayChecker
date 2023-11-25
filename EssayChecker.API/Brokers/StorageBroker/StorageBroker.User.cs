using EssayChecker.API.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker : IStorageBroker
{
    public DbSet<User> Users { get; set; }

    public async ValueTask<User> InsertUserAsync(User user) =>
        await InsertAsync<User>(user);

    public IQueryable<User> SelectUsers() => 
        SelectAll<User>();

    public async ValueTask<User> SelectUserById(Guid id) => 
        await SelectAsync<User>(id);

    public async ValueTask<User> UpdateUserAsync(User user) =>
        await UpdateAsync<User>(user);

    public async ValueTask<User> DeleteUserAsync(User user) =>
        await DeleteAsync<User>(user);  
}