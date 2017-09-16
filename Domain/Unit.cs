using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace PaulRoho.Trenz.Domain
{
    public class Unit : IFormattable
    {
        public Unit(string name, string abbr)
        {
            Name = name;
            Abbr = abbr;
        }

        public string Name { get; }
        public string Abbr { get; }

        #region Equality Checking

        protected bool Equals(Unit other)
        {
            return string.Equals(Name, other.Name) && string.Equals(Abbr, other.Abbr);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Unit) obj);
        }

        [ExcludeFromCodeCoverage]
        public override int GetHashCode()
        {
            unchecked
            {
                return (Name.GetHashCode() * 397) ^ Abbr.GetHashCode();
            }
        }

        public static bool operator ==(Unit left, Unit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Unit left, Unit right)
        {
            return !Equals(left, right);
        }

        #endregion

        #region Formatting

        public override string ToString()
        {
            return ToString(null, CultureInfo.InvariantCulture);
        }

        public string ToString(string format)
        {
            return ToString(format, null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case null:
                case "G":
                case "A":
                    return Abbr;

                case "N":
                    return Name;

                default:
                    throw new FormatException($"Format {format} is not supported.");
            }
        }

        #endregion
    }
}
