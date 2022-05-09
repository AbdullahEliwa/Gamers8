using Gamers8.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.Base
{
    public abstract class AuditableEntity<TKey> : BaseEntity<TKey>, IIsActive
    {
        public DateTimeOffset Created { get; set; }
        public string CreatedBy { get; set; }

        public DateTimeOffset? LastModified { get; set; }

        public string LastModifiedBy { get; set; }

        public bool IsActive { get; set; }
        internal void SetUpdate()
        {
            LastModified = DateTimeOffset.Now;
        }
    }
}
