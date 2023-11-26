using System.Text.Json.Serialization;
using EssayChecker.API.Models.Essays;

namespace EssayChecker.API.Models.Users;

public class User
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    [JsonIgnore]
    public virtual ICollection<Essay> Essays { get; set; }
}