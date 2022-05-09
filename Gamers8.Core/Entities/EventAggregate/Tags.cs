using Gamers8.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.EventAggregate
{
    public class Tags : AuditableEntity<string>
    {
        public string Name { get; private set; }
    }
}
