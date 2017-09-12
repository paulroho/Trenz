using System;
using System.Globalization;

namespace PaulRoho.Trenz.Domain
{
    public class Sample
    {
        public Amount Amount { get; }
        public DateTime PointInTime { get; }

        public Sample(Amount amount, DateTime pointInTime)
        {
            Amount = amount;
            PointInTime = pointInTime;
        }

        public string ToString(IFormatProvider formatProvider)
        {
            return string.Format(formatProvider, "{0} @{1}", Amount, PointInTime);
        }

        public override string ToString()
        {
            return ToString(CultureInfo.CurrentUICulture);
        }
    }
}