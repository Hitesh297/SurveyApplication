using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurveyAPI.Controllers;
using SurveyAPI.Entities;
using System.Collections.Generic;
using System.Web.Script.Serialization;

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

        [TestMethod]
        public void CreateTest()
        {
            SurveyController surveyCtrl = new SurveyController();
            Survey newSurvey = new Survey();
            newSurvey.CreatedBy = "Hitesh";
            newSurvey.CreatedDate = DateTime.Now;
            newSurvey.Description = "New Survey inserted at " + newSurvey.CreatedDate;
            newSurvey.SurveyVersions = new List<SurveyVersion>();
            
            SurveyVersion newSurveyVersion = new SurveyVersion();
            newSurveyVersion.CreatedDate = DateTime.Now;
            newSurveyVersion.IsTimeBound = false;
            newSurveyVersion.MaxUsers = 1000;
            newSurveyVersion.MinUsers = 200;
            newSurveyVersion.Status = "ACTIVE";
            newSurveyVersion.Questions = new List<Question>();

            newSurvey.SurveyVersions.Add(newSurveyVersion);

            SingleSelect newQuestion = new SingleSelect();
            newQuestion.Description = "Single select inserted";
            newQuestion.Rating = 7;

            newSurvey.SurveyVersions[0].Questions.Add(newQuestion);
            var json = new JavaScriptSerializer().Serialize(newSurvey);
            var test = surveyCtrl.CreateOrUpdate(newSurvey);

            Assert.IsNotNull(test);
        }
    }
}
