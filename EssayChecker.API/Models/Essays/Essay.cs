using System.Text.Json.Serialization;
using EssayChecker.API.Models.Feedbacks;
using EssayChecker.API.Models.Users;

namespace EssayChecker.API.Models.Essays;

public class Essay
{
    public Guid Id { get; set; }

    public Types  EssayType { get; set; }

    public string EssayContent { get; set; }

    public DateTimeOffset SubmittedTime { get; set; }

    [JsonIgnore]
    public Guid UserId { get; set; }

    [JsonIgnore]
    public User User { get; set; }

    [JsonIgnore]
    public Feedback Feedback { get; set; }
}