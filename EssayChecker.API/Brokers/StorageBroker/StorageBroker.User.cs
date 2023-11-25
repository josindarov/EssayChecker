using EssayChecker.API.Models.Users;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker : IStorageBroker
{
    public async ValueTask<User> InsertUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public IQueryable<User> SelectUsers()
    {
        throw new NotImplementedException();
    }

    public async ValueTask<User> SelectUserById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<User> UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<User> DeleteUserAsync(User user)
    {
        throw new NotImplementedException();
    }
}