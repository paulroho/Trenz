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

        #region Formatting

        public string ToString(IFormatProvider provider)
        {
            return string.Format(provider, "{0} @{1}", Amount, PointInTime);
        }

        public override string ToString()
        {
            return ToString(CultureInfo.CurrentCulture);
        }

        #endregion
    }
}