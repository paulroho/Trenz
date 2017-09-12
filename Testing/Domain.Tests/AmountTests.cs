using System;
using FluentAssertions;
using Xunit;

namespace PaulRoho.Trenz.Domain.Tests
{
    public class AmountTests
    {
        [Fact]
        public void Value_ShouldReturnTheValue()
        {
            var dummyUnit = new Unit("dummyunit", "du");
            var amount = new Amount(123.45M, dummyUnit);

            amount.Value.Should().Be(123.45M);
        }

        [Fact]
        public void Unit_ShouldReturnTheUnit()
        {
            var myUnit = new Unit("MyUnit", "mu");
            const decimal dummyValue = 123;
            var amount = new Amount(dummyValue, myUnit);

            amount.Unit.Should().Be(myUnit);
        }

        [Fact]
        public void CanBeAssignedToDecimal()
        {
            var dummyUnit = new Unit("dummyunit", "du");
            var amount = new Amount(234.56M, dummyUnit);

            // Act
            decimal v = amount;

            v.Should().Be(234.56M);
        }

        [Fact]
        public void OperatorEquals_TwoAmountsWithSameValueAndUnit_ShouldBeConsideredEqual()
        {
            var myUnit = new Unit("MyUnit", "mu");
            var a1 = new Amount(123.45M, myUnit);
            var a2 = new Amount(123.45M, myUnit);

            (a1 == a2).Should().BeTrue();
        }

        [Fact]
        public void OperatorUnequals_TwoAmountsWithSameValueAndUnit_ShouldBeConsideredEqual()
        {
            var myUnit = new Unit("MyUnit", "mu");
            var a1 = new Amount(123.45M, myUnit);
            var a2 = new Amount(123.45M, myUnit);

            (a1 != a2).Should().BeFalse();
        }

        [Fact]
        public void OperatorEquals_TwoAmountsWithDifferentValue_ShouldBeConsideredUnequal()
        {
            var myUnit = new Unit("MyUnit", "mu");
            var a1 = new Amount(123.45M, myUnit);
            var a2 = new Amount(543.21M, myUnit);

            (a1 == a2).Should().BeFalse();
        }

        [Fact]
        public void OperatorEquals_TwoAmountsWithDifferentUnits_ShouldBeConsideredUnequal()
        {
            var unit1 = new Unit("My1stUnit", "m1u");
            var unit2 = new Unit("My2ndUnit", "m2u");
            var a1 = new Amount(123.45M, unit1);
            var a2 = new Amount(123.45M, unit2);

            (a1 == a2).Should().BeFalse();
        }

        [Fact]
        public void TwoAmountsWithTheSameUnitsCanBeAdded()
        {
            var myUnit = new Unit("MyUnit", "mu");
            var a1 = new Amount(123.45M, myUnit);
            var a2 = new Amount(234.56M, myUnit);

            Amount sum = a1 + a2;

            sum.Value.Should().Be(358.01M);
            sum.Unit.Should().Be(myUnit);
        }

        [Fact]
        public void AddingTwoAmountsWithDifferentUnits_ThrowsAProperException()
        {
            var unit1 = new Unit("My1stUnit", "m1u");
            var unit2 = new Unit("My2ndUnit", "m2u");
            var a1 = new Amount(123.45M, unit1);
            var a2 = new Amount(234.56M, unit2);

            Action act = () =>
            {
                var dummy = a1 + a2;
            };

            act.ShouldThrow<InvalidOperationException>().WithMessage("*My1stUnit*My2ndUnit*");
        }

        [Fact]
        public void ToString_ShowsValueAndUnitAbbreviation()
        {
            var unit = new Unit("Unit", "un");
            var value = 123.45M;
            var amount = new Amount(value, unit);

            var actual = amount.ToString();

            actual.Should().Contain(value.ToString());
            actual.Should().Contain(unit.Abbr);
        }
    }
}
