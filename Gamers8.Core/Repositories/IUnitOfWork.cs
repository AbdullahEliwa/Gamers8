using Gamers8.Core.Repositories.SummitFeature;

namespace Gamers8.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ISummitRepository Summits { get; }
        ISummitDayRepository SummitDays { get; }
        Task<bool> Complete<T>();
    }
}
