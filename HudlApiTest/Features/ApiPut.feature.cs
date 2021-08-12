﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HudlApiTest.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ApiPut")]
    public partial class ApiPutFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ApiPut.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ApiPut", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01. Update opponent game id")]
        public virtual void _01_UpdateOpponentGameId()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01. Update opponent game id", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table11.AddRow(new string[] {
                            "1234567",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 5
 testRunner.Given("create opponent information with table details", ((string)(null)), table11, "Given ");
#line hidden
#line 8
 testRunner.Then("opponent data is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table12.AddRow(new string[] {
                            "7654321",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 9
 testRunner.When("I update opponent information", ((string)(null)), table12, "When ");
#line hidden
#line 12
 testRunner.Then("opponent data in response has new game Id \"7654321\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02. Update opponent sql id")]
        public virtual void _02_UpdateOpponentSqlId()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02. Update opponent sql id", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table13.AddRow(new string[] {
                            "1234567",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 15
 testRunner.Given("create opponent information with table details", ((string)(null)), table13, "Given ");
#line hidden
#line 18
 testRunner.Then("opponent data is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table14.AddRow(new string[] {
                            "1234567",
                            "7654321",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 19
 testRunner.When("I update opponent information", ((string)(null)), table14, "When ");
#line hidden
#line 22
 testRunner.Then("opponent data in response has new sql Id \"7654321\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03. Update opponent id")]
        public virtual void _03_UpdateOpponentId()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03. Update opponent id", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table15.AddRow(new string[] {
                            "1234567",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 25
 testRunner.Given("create opponent information with table details", ((string)(null)), table15, "Given ");
#line hidden
#line 28
 testRunner.Then("opponent data is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table16.AddRow(new string[] {
                            "1234567",
                            "7654321",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "654321",
                            "0"});
#line 29
 testRunner.When("I update opponent information", ((string)(null)), table16, "When ");
#line hidden
#line 32
 testRunner.Then("opponent data in response has new sql Id \"654321\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04. Update opponent")]
        public virtual void _04_UpdateOpponent()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04. Update opponent", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 34
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table17.AddRow(new string[] {
                            "1234567",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 35
 testRunner.Given("create opponent information with table details", ((string)(null)), table17, "Given ");
#line hidden
#line 38
 testRunner.Then("opponent data is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table18.AddRow(new string[] {
                            "1234567",
                            "7654321",
                            "2016-01-01T19:00:00",
                            "TestOpponentAbc",
                            "654321",
                            "0"});
#line 39
 testRunner.When("I update opponent information", ((string)(null)), table18, "When ");
#line hidden
#line 42
 testRunner.Then("opponent data in response has new opponent \"TestOpponentAbc\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05. Update opponent game id - invalid game id")]
        public virtual void _05_UpdateOpponentGameId_InvalidGameId()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05. Update opponent game id - invalid game id", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table19.AddRow(new string[] {
                            "1234567",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 47
 testRunner.Given("create opponent information with table details", ((string)(null)), table19, "Given ");
#line hidden
#line 50
 testRunner.Then("opponent data is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table20.AddRow(new string[] {
                            "7654321",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 51
 testRunner.When("I update opponent information", ((string)(null)), table20, "When ");
#line hidden
#line 54
 testRunner.Then("opponent data update should fail with error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06. Update opponent sql id - invalid sql id")]
        public virtual void _06_UpdateOpponentSqlId_InvalidSqlId()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06. Update opponent sql id - invalid sql id", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 57
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table21.AddRow(new string[] {
                            "1234567",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 58
 testRunner.Given("create opponent information with table details", ((string)(null)), table21, "Given ");
#line hidden
#line 61
 testRunner.Then("opponent data is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table22.AddRow(new string[] {
                            "1234567",
                            "abcdefgh",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 62
 testRunner.When("I update opponent information", ((string)(null)), table22, "When ");
#line hidden
#line 65
 testRunner.Then("opponent data update should fail with error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("07. Update opponent id - invalid opponent id")]
        public virtual void _07_UpdateOpponentId_InvalidOpponentId()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("07. Update opponent id - invalid opponent id", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 68
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table23.AddRow(new string[] {
                            "1234567",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 69
 testRunner.Given("create opponent information with table details", ((string)(null)), table23, "Given ");
#line hidden
#line 72
 testRunner.Then("opponent data is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table24.AddRow(new string[] {
                            "1234567",
                            "7654321",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "qwertvvf",
                            "0"});
#line 73
 testRunner.When("I update opponent information", ((string)(null)), table24, "When ");
#line hidden
#line 76
 testRunner.Then("opponent data update should fail with error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("08. Update opponent - invalid opponent")]
        public virtual void _08_UpdateOpponent_InvalidOpponent()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("08. Update opponent - invalid opponent", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 79
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table25.AddRow(new string[] {
                            "1234567",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 80
 testRunner.Given("create opponent information with table details", ((string)(null)), table25, "Given ");
#line hidden
#line 83
 testRunner.Then("opponent data is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table26.AddRow(new string[] {
                            "1234567",
                            "7654321",
                            "2016-01-01T19:00:00",
                            "111111",
                            "654321",
                            "0"});
#line 84
 testRunner.When("I update opponent information", ((string)(null)), table26, "When ");
#line hidden
#line 87
 testRunner.Then("opponent data update should fail with error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("09. Update all details with - invalid infomation")]
        public virtual void _09_UpdateAllDetailsWith_InvalidInfomation()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("09. Update all details with - invalid infomation", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 90
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table27.AddRow(new string[] {
                            "1234567",
                            "1234567",
                            "2016-01-01T19:00:00",
                            "TestOpponent",
                            "123456",
                            "0"});
#line 91
 testRunner.Given("create opponent information with table details", ((string)(null)), table27, "Given ");
#line hidden
#line 94
 testRunner.Then("opponent data is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "gameId",
                            "sqlId",
                            "date",
                            "opponent",
                            "opponentId",
                            "gameType"});
                table28.AddRow(new string[] {
                            "000000",
                            "acvewsl",
                            "ggee01T19",
                            "demodemo",
                            "pppcees",
                            "0"});
#line 95
 testRunner.When("I update opponent information", ((string)(null)), table28, "When ");
#line hidden
#line 98
 testRunner.Then("opponent data update should fail with error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
