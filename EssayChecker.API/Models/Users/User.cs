using EssayChecker.API.Models.Essays;

namespace EssayChecker.API.Models.Users;

public class User
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Essay> Essays { get; set; }
}