using FluentAssertions;
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
        public void ToString_RetrievesTheName()
        {
            var unit = new Unit("MyUnit", "mu");

            string asString = unit.ToString();

            asString.Should().Be("MyUnit");
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