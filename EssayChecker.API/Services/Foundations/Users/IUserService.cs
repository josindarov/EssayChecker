using EssayChecker.API.Models.Users;

namespace EssayChecker.API.Services.Foundations.Users;

public interface IUserService
{
    ValueTask<User> AddUserAsync(User user);
    ValueTask<User> RetriveUserByIdAsync(Guid id);
    IQueryable<User> RetrieveAll();
    ValueTask<User> ModifyUserAsync(User user);
    ValueTask<User> RemoveUserAsync(User user);
}