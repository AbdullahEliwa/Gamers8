using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Core.Entities.Base
{
    public abstract class BaseEntity<TKey>
    {
        public virtual TKey Id { get; set; }
        public bool IsActive { get; private set; }
        public byte[] RowVersion { get; set; }

        public virtual string GetLocalizedPropertyValue(string propertyName)
        {
            var currentCulture = CultureInfo.CurrentCulture;
            var twoLetterCulture = currentCulture.Name;

            var culturePropertyName = propertyName + twoLetterCulture;

            return (string)GetType().GetProperty(culturePropertyName, BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Instance)?.GetValue(this, null);
        }
    }
}
