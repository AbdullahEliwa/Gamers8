using Booking.Core.ValueObjects;
using Gamers8.Core.Entities.Base;
using Gamers8.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.AttractionsAggregate
{
    public class Attraction : AuditableEntity<Guid>
    {
        public string Title { get;  set; }
        public AttractionCategories AttractionCategory { get;  set; }
        public string DefaultImagePath { get;  set; }
        public string Description { get;  set; }
        public SeasonZones SeasonZone { get;  set; }
        public DateTimeRange DateTime { get; set; }
        public string OpeningTimes { get; set; }
        public int AgeGroupFrom { get; set; }
        public bool IncludedInEntranceTicket { get; set; } = false;
        public bool RequiresSignup { get; set; } = false;
        public bool IsFeaturedEvent { get; set; } = false;




    }
}
