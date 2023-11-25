using EssayChecker.API.Brokers.StorageBroker;
using EssayChecker.API.Models.Users;

namespace EssayChecker.API.Services.Foundations.Users;

public class UserService : IUserService
{
    private readonly IStorageBroker storageBroker;

    public UserService(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }
    
    public async ValueTask<User> AddUserAsync(User user)
    {
        return await storageBroker.InsertUserAsync(user);
    }

    public async ValueTask<User> RetriveUserByIdAsync(Guid id)
    {
        return await storageBroker.SelectUserById(id);
    }

    public IQueryable<User> RetrieveAll()
    {
        return storageBroker.SelectUsers();
    }

    public async ValueTask<User> ModifyUserAsync(User user)
    {
        return await storageBroker.UpdateUserAsync(user);
    }

    public async ValueTask<User> RemoveUserAsync(User user)
    {
        return await storageBroker.DeleteUserAsync(user);
    }
}