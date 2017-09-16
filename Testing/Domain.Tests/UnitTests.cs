using System;
using FluentAssertions;
using PaulRoho.Trenz.Domain.Tests.TestSupport;
using Xunit;

namespace PaulRoho.Trenz.Domain.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Name_ReturnsTheName()
        {
            var unit = new Unit("The Name", "d/c");

            var name = unit.Name;

            name.Should().Be("The Name");
        }

        [Fact]
        public void Abbr_ReturnsTheAbbreviation()
        {
            var unit = new Unit("The Unit", "du");

            var abbreviation = unit.Abbr;

            abbreviation.Should().Be("du");
        }

        [Fact]
        public void ToString_RetrievesTheAbbreviation()
        {
            var unit = new Unit("MyUnit", "mu");

            var asString = unit.ToString();

            asString.Should().Be("mu");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("G")]
        [InlineData("A")]
        public void ToString_WithFormatAorG_ReturnsTheAbbreviation(string format)
        {
            var unit = new Unit("MyUnit", "mu");

            var asString = unit.ToString(format);

            asString.Should().Be("mu");
        }

        [Theory]
        [InlineData("N")]
        public void ToString_WithFormatN_ReturnsTheName(string format)
        {
            var unit = new Unit("MyUnit", "mu");

            var asString = unit.ToString(format);

            asString.Should().Be("MyUnit");
        }

        [Theory]
        [InlineData("g")]
        [InlineData("a")]
        [InlineData("n")]
        [InlineData("anything")]
        public void ToString_WithInvalidFormat_ThrowsAFormatException(string format)
        {
            var unit = Some.Unit;

            Assert.Throws<FormatException>(
                () => unit.ToString(format)
            );
        }

        [Theory]
        [InlineData("123 {0}", "123 kg")]
        [InlineData("123{0:G}", "123kg")]
        [InlineData("123{0:A}", "123kg")]
        [InlineData("123 {0:N}s", "123 Kilograms")]
        public void FormatString_IsConsideredInMixedStringFormats(string format, string expectedFormatted)
        {
            var unit = new Unit("Kilogram", "kg");

            var actual = string.Format(format, unit);

            actual.Should().Be(expectedFormatted);
        }

        [Fact]
        public void UnitsWithSameValues_AreConsideredEqual()
        {
            var unit1 = new Unit("My Unit", "mu");
            var unit2 = new Unit("My Unit", "mu");

            (unit1 == unit2).Should().BeTrue();
        }

        [Fact]
        public void UnitsWithDifferentName_AreConsideredUnequal()
        {
            var unit1 = new Unit("My Unit 1", "mu");
            var unit2 = new Unit("My Unit 2", "mu");

            (unit1 == unit2).Should().BeFalse();
        }

        [Fact]
        public void UnitsWithDifferentAbbreviation_AreConsideredUnequal()
        {
            var unit1 = new Unit("My Unit", "mu1");
            var unit2 = new Unit("My Unit", "mu2");

            (unit1 == unit2).Should().BeFalse();
        }
    }
}