using Gamers8.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.SummitAggregate
{
    public class SummitDay : AuditableEntity<int>
    {
        public DateTime Date { get; set; }
    }
}
