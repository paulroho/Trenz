using System;
using Ploeh.AutoFixture;

namespace PaulRoho.Trenz.Domain.Tests.TestSupport
{
    public class Some
    {
        private static readonly Random Random = new Random(DateTime.Now.Second);
        private static readonly Fixture Fixture = new Fixture();

        public static Amount Amount => Fixture.Create<Amount>();
        public static Unit Unit => Fixture.Create<Unit>();
        public static string String(int length) => Fixture.Create<string>().Substring(0, length);
        public static decimal Value => Fixture.Create<decimal>();
        public static DateTime PointInTime => DateTime.Now;
    }
}