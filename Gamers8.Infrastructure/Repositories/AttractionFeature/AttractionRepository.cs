using Booking.Infrastructure.Persistence;
using Gamers8.Core.Entities.AttractionsAggregate;
using Gamers8.Core.Repositories.AttractionFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Infrastructure.Repositories.AttractionFeature
{
    public class AttractionRepository : Repository<Attraction>, IAttractionRepository
    {
        public AttractionRepository(Gamers8Context context) : base(context)
        {

        }
    }
}
