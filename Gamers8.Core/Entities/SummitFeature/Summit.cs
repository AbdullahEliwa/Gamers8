using Booking.Core.ValueObjects;
using Gamers8.Core.Entities.Base;
using Gamers8.Core.Entities.SharedAggregate;
using Gamers8.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.SummitAggregate
{
    public class Summit : AuditableEntity<Guid>
    {
        public Summit()
        {
            Tags = new HashSet<Tag>();
            Speakers = new HashSet<Speaker>();
        }

        public DescriptionLocalized Title { get; set; }
        public DescriptionLocalized DefaultImagePath { get; set; }
        public SeasonZones SeasonZone { get; set; }
        public DateTimeRange DateTime { get; set; }
        public DescriptionLocalized ProgramFilePath { get; set; }
        public byte? AgeGroupFrom { get; set; }
        public bool RequireSignup { get; set; }
        public bool IsIncludedInEntranceTicket { get; set; }
        public bool IsFeaturedEvent { get; set; }

        public DescriptionLocalized FactsSheet { get; set; }

        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
    }
}
