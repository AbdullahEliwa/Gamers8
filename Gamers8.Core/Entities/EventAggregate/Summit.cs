using Booking.Core.ValueObjects;
using Gamers8.Core.Entities.Base;
using Gamers8.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.EventAggregate
{
    public class Summit : AuditableEntity<Guid>
    {
        public DescriptionLocalized Title { get; private set; }
        public string DefaultImagePath { get; private set; }
        public SeasonZones SeasonZone { get; private set; }
        public DateTimeRange DateTime { get; private set; }
        public string ProgramFilePath { get; private set; }
        public byte AgeGroupFrom { get; private set; }
        //Default value = true
        public bool RequireSignup { get; private set; }
        //Default value = true
        public bool IsIncludedInEntranceTicket { get; private set; }
        //Default value = true
        public bool IsFeaturedEvent { get; private set; }

        public DescriptionLocalized FactsSheet { get; private set; }





        public IEnumerable<Tags> Tags { get; private set; }
    }
}
