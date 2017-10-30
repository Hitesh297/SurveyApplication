using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurveyAPI.Controllers;

namespace SurveyAPITest
{
    [TestClass]
    public class SurveyControllerTest
    {
        [TestMethod]
        public void GetTest()
        {
            SurveyController surveyCtrl = new SurveyController();
            var test = surveyCtrl.Get();
            

        }
    }
}
