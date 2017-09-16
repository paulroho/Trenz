namespace PaulRoho.Trenz.Domain.Tests.TestSupport
{
    public static class TestDataExtensions
    {
        public static Amount WithValue(this Amount original, decimal value)
        {
            return new Amount(value, original.Unit);
        }

        public static Sample WithValue(this Sample original, decimal value)
        {
            return new Sample(original.Amount.WithValue(value), 
                              original.PointInTime);
        }
    }
}