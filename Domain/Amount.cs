using System;

namespace PaulRoho.Trenz.Domain
{
    public class Amount
    {
        public Amount(decimal value, Unit unit)
        {
            Value = value;
            Unit = unit;
        }

        public decimal Value { get; }

        public Unit Unit { get; }

        public static implicit operator decimal(Amount amount) => amount.Value;

        public static Amount operator +(Amount lhs, Amount rhs)
        {
            if (lhs.Unit != rhs.Unit)
                throw new InvalidOperationException($"Cannot add amounts with different units (\"{lhs.Unit}\" vs. \"{rhs.Unit}\").");

            return new Amount(lhs.Value + rhs.Value, lhs.Unit);
        }

        protected bool Equals(Amount other)
        {
            return Value == other.Value && Unit.Equals(other.Unit);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Amount) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Value.GetHashCode() * 397) ^ Unit.GetHashCode();
            }
        }

        public static bool operator ==(Amount left, Amount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Amount left, Amount right)
        {
            return !Equals(left, right);
        }
    }
}