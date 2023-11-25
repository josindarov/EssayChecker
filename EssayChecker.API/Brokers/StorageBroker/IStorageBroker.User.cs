using EssayChecker.API.Models.Users;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial interface IStorageBroker
{
    ValueTask<User> InsertUserAsync(User user);
    IQueryable<User> SelectUsers();
    ValueTask<User> SelectUserById(Guid id);
    ValueTask<User> UpdateUserAsync(User user);
    ValueTask<User> DeleteUserAsync(User user);
}