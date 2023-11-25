using EssayChecker.API.Models.Feedbacks;
using EssayChecker.API.Models.Users;

namespace EssayChecker.API.Models.Essays;

public class Essay
{
    public Guid Id { get; set; }

    public Types  EssayType { get; set; }

    public string EssayContent { get; set; }

    public DateTimeOffset SubmittedTime { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; }

    public Feedback Feedback { get; set; }
}