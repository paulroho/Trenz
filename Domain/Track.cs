using System;
using System.Collections;
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
                new Sample(new Amount(0, bf), new DateTime(2018, 1, 1)),
                new Sample(new Amount(1, bf), new DateTime(2018, 1, 2)),
                new Sample(new Amount(2, bf), new DateTime(2018, 1, 3)),
                new Sample(new Amount(3, bf), new DateTime(2018, 1, 4)),
            };
        }
    }
}