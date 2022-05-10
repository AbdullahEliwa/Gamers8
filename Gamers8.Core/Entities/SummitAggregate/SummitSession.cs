using Booking.Core.ValueObjects;
using Gamers8.Core.Entities.Base;
using Gamers8.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.SummitAggregate
{
    public class SummitSession : AuditableEntity<Guid>
    {
        public DescriptionLocalized Title { get; set; }
        public DateTimeRange DateTime { get; set; }

        public DescriptionLocalized Desciption { get; set; }
        public SeasonZones SeasonZone { get; set; }

    }
}
