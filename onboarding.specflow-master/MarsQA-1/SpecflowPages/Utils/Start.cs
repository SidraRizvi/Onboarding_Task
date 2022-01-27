﻿using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReports();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            test = Extent.StartTest(context.FeatureInfo.Title);
        }


        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.MarsDataPath, "Credentials");
            //call the SignIn class
            SignIn.SigninStep();
        }

        [AfterScenario]
        public void TearDown()
        {
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            var status = TestContext.CurrentContext.Result.Outcome.Status;

            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, status + errorMessage);
            }
            else if (status == TestStatus.Passed)
            {
                test.Log(LogStatus.Pass, "Test is passed");
            }


            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();

            // end test. (Reports)
            CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();


        }
    }
}
