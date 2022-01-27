// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MarsQA_1.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Join")]
    public partial class JoinFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Join.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Join", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("When I am on Join page and want to SignIn instead of creating an account then Sig" +
            "nIn page should be available.")]
        [NUnit.Framework.CategoryAttribute("Home@Join")]
        public virtual void WhenIAmOnJoinPageAndWantToSignInInsteadOfCreatingAnAccountThenSignInPageShouldBeAvailable_()
        {
            string[] tagsOfScenario = new string[] {
                    "Home@Join"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I am on Join page and want to SignIn instead of creating an account then Sig" +
                    "nIn page should be available.", null, new string[] {
                        "Home@Join"});
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
#line 6
testRunner.Given("I am on Join page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
testRunner.And("Sign in link is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
testRunner.When("I Click on SignIn link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
testRunner.Then("Directs me to the SignIn page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("On filling my details on Joining form I should be registered successfully")]
        [NUnit.Framework.CategoryAttribute("Home@Join")]
        public virtual void OnFillingMyDetailsOnJoiningFormIShouldBeRegisteredSuccessfully()
        {
            string[] tagsOfScenario = new string[] {
                    "Home@Join"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("On filling my details on Joining form I should be registered successfully", null, new string[] {
                        "Home@Join"});
#line 12
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
#line 14
   testRunner.Given("I Launched the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
   testRunner.And("I click on Join Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
   testRunner.When("I fill the form with <Firstname> <Lastname> <Emailaddress> <Password> and <Confir" +
                        "mpassword>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
   testRunner.And("Check the Terms and conditions box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
   testRunner.And("I Click the Join button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
   testRunner.Then("<Message> should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Firstname",
                            "Lastname",
                            "Emailaddress",
                            "Password",
                            "Confirmpassword",
                            "Message"});
                table3.AddRow(new string[] {
                            "123456",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "Names must contain at least one letter"});
                table3.AddRow(new string[] {
                            "#$%@#",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "Names must contain at least one letter"});
                table3.AddRow(new string[] {
                            "",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "This is a required field"});
                table3.AddRow(new string[] {
                            "123$@^",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "Names must contain at least one letter"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "Registeration sucessful"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "This name has already been used to register an account"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "123456",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "Names must contain at least one letter"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "#$%@#",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "Names must contain at least one letter"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "123$@^",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "Names must contain at least one letter"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "This is a required field"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "sid6638659",
                            "sid6638659",
                            "This email has already been used to register an account"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "abcd@123.com",
                            "123456",
                            "123456",
                            "This email is not valid"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "abcd123.com",
                            "123456",
                            "123456",
                            "Please enter a valid email address"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "",
                            "123456",
                            "123456",
                            "This is a required field"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "12345",
                            "12345",
                            "Password must be at least 6 characters"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "",
                            "",
                            "These fields are required"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "1234567",
                            "123456",
                            "password does not match password"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "sidr_riz@yahoo.com",
                            "123&*%",
                            "123&*%",
                            "Registeration sucessful"});
                table3.AddRow(new string[] {
                            "Sidra",
                            "Rizvi",
                            "sidra_riz@yahoo.com",
                            "123456",
                            "1234567",
                            "Does not match password"});
#line 20
   testRunner.And("I should be directed to the SignIn page", ((string)(null)), table3, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I forget my password then Forgot Password Link should be available to reset " +
            "it")]
        [NUnit.Framework.CategoryAttribute("Home@ForgotmyPassword")]
        public virtual void WhenIForgetMyPasswordThenForgotPasswordLinkShouldBeAvailableToResetIt()
        {
            string[] tagsOfScenario = new string[] {
                    "Home@ForgotmyPassword"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I forget my password then Forgot Password Link should be available to reset " +
                    "it", null, new string[] {
                        "Home@ForgotmyPassword"});
#line 45
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
#line 47
    testRunner.Given("I Click on Forgot password link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 48
    testRunner.And("Email Verification page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
    testRunner.When("I enter the valid email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
    testRunner.And("Click on Send Verification Email button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
    testRunner.Then("password reset email should be sent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
    testRunner.And("\"Email has been sent\" message should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
    testRunner.And("Verify Email is delivered to the correct email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I am on Forgot password page I should be directed to Sign in page on recalli" +
            "ng password.")]
        [NUnit.Framework.CategoryAttribute("Home@ForgotmyPassword")]
        public virtual void WhenIAmOnForgotPasswordPageIShouldBeDirectedToSignInPageOnRecallingPassword_()
        {
            string[] tagsOfScenario = new string[] {
                    "Home@ForgotmyPassword"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I am on Forgot password page I should be directed to Sign in page on recalli" +
                    "ng password.", null, new string[] {
                        "Home@ForgotmyPassword"});
#line 56
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
#line 58
testRunner.Given("I am on Forgot password link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 59
testRunner.When("I Click Remember your password link?", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
testRunner.Then("I should be directed to SignIn page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I click on Sign out I should be Successfully Sign out from the application")]
        [NUnit.Framework.CategoryAttribute("Home@Profile@Signout")]
        public virtual void WhenIClickOnSignOutIShouldBeSuccessfullySignOutFromTheApplication()
        {
            string[] tagsOfScenario = new string[] {
                    "Home@Profile@Signout"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I click on Sign out I should be Successfully Sign out from the application", null, new string[] {
                        "Home@Profile@Signout"});
#line 63
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
#line 64
testRunner.Given("I am on Profile Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 65
testRunner.And("Sign Out page is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
testRunner.When("I Click Sign Out Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
testRunner.Then("I should be Sign out successfully from the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
