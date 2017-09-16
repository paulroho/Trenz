using System;
using System.Linq;

namespace PaulRoho.Trenz.Domain.Tests.TestSupport
{
    public static class Some
    {
        private static readonly Random Random = new Random(DateTime.Now.Second);

        public static Amount Amount => new Amount(Some.Value, Some.Unit);
        public static Unit Unit => new Unit(Some.String(5), Some.String(2));
        public static string String(int length) => string.Join("", Enumerable.Range(1, length).Select(_ => (char) Random.Next('a', 'z')));
        public static decimal Value => (decimal) Random.NextDouble();
        public static DateTime PointInTime => DateTime.Now;
        public static Sample Sample => new Sample(Some.Amount, Some.PointInTime);
    }
}