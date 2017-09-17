﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PaulRoho.Trenz.Domain.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ProjectingFutureAmountsFeature : Xunit.IClassFixture<ProjectingFutureAmountsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ProjectWithSimpleSeries.feature"
#line hidden
        
        public ProjectingFutureAmountsFeature(ProjectingFutureAmountsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Projecting future Amounts", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Project with simple series")]
        [Xunit.TraitAttribute("FeatureTitle", "Projecting future Amounts")]
        [Xunit.TraitAttribute("Description", "Project with simple series")]
        public virtual void ProjectWithSimpleSeries()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Project with simple series", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Model",
                        "One each day"});
            table1.AddRow(new string[] {
                        "Seed",
                        "123bf @2017-12-31"});
#line 5
testRunner.Given("a Track \"Breakfasts\" with", ((string)(null)), table1, "Given ");
#line 8
  testRunner.And("a model \"One each day\" with a single series \"each day +1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Sample"});
            table2.AddRow(new string[] {
                        "124bf @2018-01-01 00:00:00"});
            table2.AddRow(new string[] {
                        "125bf @2018-01-02 00:00:00"});
            table2.AddRow(new string[] {
                        "126bf @2018-01-03 00:00:00"});
            table2.AddRow(new string[] {
                        "127bf @2018-01-04 00:00:00"});
#line 10
testRunner.When("I ask for the Amount of the Track \"Breakfasts\" from 2018-01-01 to 2018-01-04 I ge" +
                    "t", ((string)(null)), table2, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ProjectingFutureAmountsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ProjectingFutureAmountsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
