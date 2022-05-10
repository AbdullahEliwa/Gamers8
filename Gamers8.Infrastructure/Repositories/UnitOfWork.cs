using Booking.Infrastructure.Persistence;
using Gamers8.Core.Repositories;
using Gamers8.Core.Repositories.SummitFeature;

namespace Gamers8.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Gamers8Context _context;
        public UnitOfWork(Gamers8Context context,
                         ISummitRepository summits,
                         ISummitDayRepository summitDay)
        {
            this._context = context;
            this.Summits = summits;
            this.SummitDays = summitDay;
        }


        public ISummitRepository Summits { get; private set; }
        public ISummitDayRepository SummitDays { get; private set; }
        public Task<bool> Complete<T>()
        {
            return _context.SaveEntitiesAsync<T>();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
