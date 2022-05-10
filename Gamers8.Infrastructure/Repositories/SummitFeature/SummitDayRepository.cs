using Booking.Infrastructure.Persistence;
using Gamers8.Core.Entities.SummitAggregate;
using Gamers8.Core.Repositories.SummitFeature;

namespace Gamers8.Infrastructure.Repositories.SummitFeature
{
    public class SummitDayRepository : Repository<SummitDay>, ISummitDayRepository
    {
        public SummitDayRepository(Gamers8Context context)
            : base(context)
        {

        }
    }
}
