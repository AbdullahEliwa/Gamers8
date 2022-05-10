using Gamers8.Core.Entities.Base;
using Gamers8.Core.Entities.EventAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.SharedAggregate
{
    public class Tag
    {
        public Tag()
        {
            Summits = new HashSet<Summit>();
        }

        public string Name { get; private set; }

        public IEnumerable<Summit> Summits { get; set; }
    }
}
