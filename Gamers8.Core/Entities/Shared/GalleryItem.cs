using Booking.Core.ValueObjects;
using Gamers8.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.AttractionsAggregate
{
    public class GalleryItem : AuditableEntity<Guid>
    {
        public string ItemName { get; set; }
        public string FilePath { get; set; }
        public Attraction Attraction { get; set; }
    }
}
