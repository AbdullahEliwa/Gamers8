
using Booking.Core.Abstractions;
using System;
using System.Collections.Generic;

namespace Booking.Core.ValueObjects
{
    public class DateTimeOffsetRange : ValueObject
    {
        public DateTimeOffset Start { get; private set; }
        public DateTimeOffset End { get; private set; }

        public DateTimeOffsetRange(DateTimeOffset start, DateTimeOffset end)
        {
            //ToDo: Add Package if needed
            //Guard.Against.OutOfRange(start, nameof(start), start, end);
            Start = start;
            End = end;
        }

        public DateTimeOffsetRange(DateTimeOffset start, TimeSpan duration)
            : this(start, start.Add(duration))
        {
        }

        //public bool Overlaps(DateTimeOffsetRange dateTimeRange)
        //{
        //    return Start < dateTimeRange.End &&
        //        End > dateTimeRange.Start;
        //}

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Start;
            yield return End;
        }
    }
}
