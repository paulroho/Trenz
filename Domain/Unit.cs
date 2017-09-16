using System.Diagnostics.CodeAnalysis;

namespace PaulRoho.Trenz.Domain
{
    public class Unit
    {
        public Unit(string name, string abbr)
        {
            Name = name;
            Abbr = abbr;
        }

        public string Name { get; }
        public string Abbr { get; }

        public override string ToString()
        {
            return Abbr;
        }

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
    }
}
