using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.Base
{
    public abstract class AuditableEntity<TKey> : BaseEntity<TKey>
    {
        public DateTimeOffset Created { get; set; }
        public string CreatedBy { get; set; }

        public DateTimeOffset? LastModified { get; set; }

        public string LastModifiedBy { get; set; }
        internal void SetUpdate()
        {
            LastModified = DateTimeOffset.Now;
        }
    }
}
