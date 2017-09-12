using System.Globalization;
using FluentAssertions;
using PaulRoho.Trenz.Domain.Tests.TestSupport;
using Xunit;

namespace PaulRoho.Trenz.Domain.Tests
{
    public class SampleTests
    {
        [Fact]
        public void PointInTime_ReturnsThePointInTime()
        {
            var somePointInTime = Some.PointInTime;
            var sample = new Sample(Some.Amount, somePointInTime);

            sample.PointInTime.Should().Be(somePointInTime);
        }

        [Fact]
        public void Amount_ReturnsTheAmount()
        {
            var someAmount = Some.Amount;
            var sample = new Sample(someAmount, Some.PointInTime);

            sample.Amount.Should().Be(someAmount);
        }

        [Fact]
        public void ToString_ContainsAmountAndPointInTime()
        {
            var theAmount = Some.Amount;
            var thePointInTime = Some.PointInTime;
            var sample = new Sample(theAmount, thePointInTime);

            var actual = sample.ToString();

            actual.Should().Contain(theAmount.Value.ToString(CultureInfo.CurrentCulture));
            actual.Should().Contain(theAmount.Unit.Abbr);
            actual.Should().Contain(thePointInTime.Year.ToString());
            actual.Should().Contain(thePointInTime.Minute.ToString());
        }
    }
}