using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Gamers8.Core.Abstractions
{
    // Learn more: https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/implement-value-objects
    public abstract class ValueObject
    {
        protected static bool EqualOperator(ValueObject left, ValueObject right)
        {
            if (left is null ^ right is null)
            {
                return false;
            }

            return left?.Equals(right) != false;
        }

        protected static bool NotEqualOperator(ValueObject left, ValueObject right)
        {
            return !EqualOperator(left, right);
        }

        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (ValueObject)obj;
            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
        public virtual string GetLocalizedPropertyValue(string propertyName)
        {
            var currentCulture = CultureInfo.CurrentCulture;
            var twoLetterCulture = currentCulture.TwoLetterISOLanguageName;

            var culturePropertyName = propertyName + twoLetterCulture;

            return (string)GetType().GetProperty(culturePropertyName, BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Instance)?.GetValue(this, null);
        }
    }
}
