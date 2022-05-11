using Booking.Core.ValueObjects;
using Gamers8.Core.Entities.Base;
using Gamers8.Core.Entities.SharedAggregate;
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
        public Attraction()
        {
            Tags = new HashSet<Tag>();
            GalleryItems= new HashSet<GalleryItem>();
        }
        public string Title { get;  set; }
        public AttractionCategories AttractionCategory { get;  set; }
        public string DefaultImagePath { get;  set; }
        public DescriptionLocalized Description { get;  set; }
        public SeasonZones SeasonZone { get;  set; }
        public DateTimeRange DateTime { get; set; }
        public DescriptionLocalized OpeningTimes { get; set; }
        public int AgeGroupFrom { get; set; }
        public bool IncludedInEntranceTicket { get; set; }
        public bool RequiresSignup { get; set; }
        public bool IsFeaturedEvent { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<GalleryItem> GalleryItems { get; set; }


       



    }
}
