using System.Text.Json.Serialization;
using EssayChecker.API.Models.Essays;

namespace EssayChecker.API.Models.Feedbacks;

public class Feedback
{
    public Guid Id { get; set; }

    public string Comment { get; set; }

    public float Mark { get; set; }

    [JsonIgnore]
    public Guid EssayId { get; set; }

    [JsonIgnore]
    public Essay Essay { get; set; }
}