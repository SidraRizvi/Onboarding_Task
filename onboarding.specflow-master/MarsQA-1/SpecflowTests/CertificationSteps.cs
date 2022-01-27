using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests
{
    [Binding]
    public class CertificationSteps
    {
      
            

        [Given(@"Certification Details")]
        public void GivenCertificationDetails()
        {
            //Read data from excel spreadsheet
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.DataDataPath}", "Certifications");
           
            //Assertion to varify sucessful Login
            
            Certification.AddCertification();
            Certification.AddCertificate_Verify();

        }       
            


        [Given(@"Modified Certification details")]
        public void GivenModifiedCertificationDetails()
        {
            //Read data from excel spreadsheet
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.DataDataPath}", "EditCertifications");
            Certification.EditCertfications();
            Certification.EditCertificate_Verify();
        }

        [Given(@"Delete Certification")]
        public void GivenDeleteCertification()
        {
            Certification.DeleteCertification();
            Certification.DeleteCertificate_Verify();
        }


    }
}
