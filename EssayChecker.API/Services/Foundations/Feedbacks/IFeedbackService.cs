using EssayChecker.API.Models.Feedbacks;

namespace EssayChecker.API.Services.Foundations.Feedbacks;

public interface IFeedbackService
{
    ValueTask<Feedback> AddFeedbackAsync(Feedback feedback);
    ValueTask<Feedback> RetriveFeedbackByIdAsync(Guid id);
    IQueryable<Feedback> RetriveAll();
}