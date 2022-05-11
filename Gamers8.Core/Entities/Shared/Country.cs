using Booking.Core.ValueObjects;
using Gamers8.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.SharedAggregate
{
    public class Country : AuditableEntity<int>
    {
        public DescriptionLocalized Name { get; set; }
    }
}
