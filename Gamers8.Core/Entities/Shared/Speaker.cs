using Booking.Core.ValueObjects;
using Gamers8.Core.Entities.Base;
using Gamers8.Core.Entities.SummitAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.SharedAggregate
{
    public class Speaker : AuditableEntity<Guid>
    {
        public Speaker()
        {
            Summits = new HashSet<Summit>();
        }

        public DescriptionLocalized Name { get; set; }
        public string PhotoPath { get; set; }
        public DescriptionLocalized JobTitle { get; set; }
        public DescriptionLocalized Employer { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public DescriptionLocalized Brief { get; set; }
        public string LinkedInProfile { get; set; }
        public string SocialMediaProfile { get; set; }

        public IEnumerable<Summit> Summits { get; set; }




    }
}
