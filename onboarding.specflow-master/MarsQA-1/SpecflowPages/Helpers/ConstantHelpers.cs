﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";

        //Mars.Xlsx Path
        private static string CurrentPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

        public static string MarsDataPath = CurrentPath + @"MarsQA-1\SpecflowTests\Data\Mars.xlsx";

        public static string DataDataPath = CurrentPath + @"MarsQA-1\SpecflowTests\Data\Data.xlsx";

        //ScreenshotPath
        public static string ScreenshotPath = CurrentPath + @"MarsQA-1\TestReports\Screenshots\";

        //ExtentReportsPath
        public static string ReportsPath = CurrentPath + @"MarsQA-1\TestReports\Test_files\" + DateTime.Now.ToString("ddMMyy HHmmss") + ".html";

        //ReportXML Path
        public static string ReportXMLPath = CurrentPath + @"MarsQA-1\TestReports" + "ExtentRepot_Config.xml";

    }
    

}
