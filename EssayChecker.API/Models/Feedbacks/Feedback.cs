using EssayChecker.API.Models.Essays;

namespace EssayChecker.API.Models.Feedbacks;

public class Feedback
{
    public Guid Id { get; set; }

    public string Comment { get; set; }

    public float Mark { get; set; }

    public Guid EssayId { get; set; }

    public Essay Essay { get; set; }
}