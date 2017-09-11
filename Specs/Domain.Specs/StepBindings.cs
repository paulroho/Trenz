using System;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PaulRoho.Trenz.Domain.Specs
{
    [Binding]
    public class StepBindings
    {
        private readonly DomainSpecDriver _driver;

        public StepBindings(DomainSpecDriver driver)
        {
            _driver = driver;
        }

        [Given(@"a Track ""(.*)"" with")]
        public void GivenATrackWith(string trackName, Table paramTable)
        {
            _driver.Track = CreateTrack(trackName, paramTable);
        }

        [Given(@"a model ""(.*)"" with a single series ""(.*)""")]
        public void GivenAModelWithASingleSeries(string modelName, string seriesName)
        {
            _driver.Track.Model = CreateSingleSeriesModel(modelName, seriesName);
        }

        [When(@"I ask for the Amount of the Track ""(.*)"" from (.*) to (.*) I get")]
        public void WhenIAskForTheAmountOfTheTrackFrom_To_IGet(string trackName, DateTime from, DateTime to, Table expectedSamplesTable)
        {
            var trend = _driver.Track.GetTrend(from, to);

            expectedSamplesTable.CompareToSet(trend.Select(s => new {Sample = s.ToString()}), sequentialEquality: true);
        }

        private Track CreateTrack(string trackName, Table paramTable)
        {
            return new Track();
        }

        private Model CreateSingleSeriesModel(string modelName, string seriesName)
        {
            return new Model();
        }
    }
}
