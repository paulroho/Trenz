using System;
using System.Collections.Generic;

namespace PaulRoho.Trenz.Domain
{
    public class Track
    {
        public Model Model { get; set; }

        public IEnumerable<Sample> GetTrend(DateTime @from, DateTime to)
        {
            var bf = new Unit("Breakfasts", "bf");
            return new List<Sample>
            {
                new Sample(new Amount(123, bf), new DateTime(2018, 1, 1)),
                new Sample(new Amount(124, bf), new DateTime(2018, 1, 2)),
                new Sample(new Amount(125, bf), new DateTime(2018, 1, 3)),
                new Sample(new Amount(126, bf), new DateTime(2018, 1, 4)),
            };
        }
    }
}