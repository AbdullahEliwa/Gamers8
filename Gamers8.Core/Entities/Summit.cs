using Booking.Core.ValueObjects;
using Gamers8.Core.Entities.Base;
using Gamers8.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities
{
    public class Summit : AuditableEntity<Guid>
    {
        public DescriptionLocalized Title { get; private set; }
        public DateTimeOffsetRange DateTime { get; private set; }
        public DescriptionLocalized FactSheet { get; private set; }
        public string ProgramFile { get; private set; }
        public string FactSheetFile { get; private set; }
        public string DefaultImage { get; private set; }
        public string AgeGroup { get; private set; }
        public bool RequireSignup { get; private set; }
        public bool IsIncludedInEntranceTicket { get; private set; }
        public bool IsFeaturedEvent { get; private set; }
        public SeasonZones SeasonZone { get; private set; }
        public IEnumerable<Tags> Tags { get; private set; }
    }
}
