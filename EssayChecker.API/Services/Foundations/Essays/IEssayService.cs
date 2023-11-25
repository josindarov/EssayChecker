using EssayChecker.API.Models.Essays;

namespace EssayChecker.API.Services.Foundations.Essays;

public interface IEssayService
{
    ValueTask<Essay> AddEssayAsync(Essay essay);
    ValueTask<Essay> RetriveEssayByIdAsync(Guid id);
    IQueryable<Essay> RetriveAllEssay();
    ValueTask<Essay> RemoveEssayAsync(Essay essay);
}