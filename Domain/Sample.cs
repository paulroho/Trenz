using System;

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

        public override string ToString()
        {
            return $"{Amount} @{PointInTime}";
        }
    }
}