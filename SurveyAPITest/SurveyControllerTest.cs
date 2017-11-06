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
        public void CreateOrUpdateTest()
        {
            SurveyController surveyCtrl = new SurveyController();
            Survey newSurvey = new Survey();
            newSurvey.CreatedBy = "Hitesh";
            newSurvey.CreatedDate = DateTime.Now;
            newSurvey.Description = "New Survey inserted at " + newSurvey.CreatedDate;
            newSurvey.SurveyVersions = new List<SurveyVersion>();
            
            SurveyVersion newSurveyVersion1 = new SurveyVersion();
            newSurveyVersion1.CreatedDate = DateTime.Now;
            newSurveyVersion1.IsTimeBound = false;
            newSurveyVersion1.MaxUsers = 1000;
            newSurveyVersion1.MinUsers = 200;
            newSurveyVersion1.Status = "ACTIVE";
            newSurveyVersion1.Questions = new List<Question>();

            SurveyVersion newSurveyVersion2 = new SurveyVersion();
            newSurveyVersion2.CreatedDate = DateTime.Now;
            newSurveyVersion2.IsTimeBound = false;
            newSurveyVersion2.MaxUsers = 1000;
            newSurveyVersion2.MinUsers = 200;
            newSurveyVersion2.Status = "CLOSED";
            newSurveyVersion2.Questions = new List<Question>();

            SurveyVersion newSurveyVersion3 = new SurveyVersion();
            newSurveyVersion3.CreatedDate = DateTime.Now;
            newSurveyVersion3.IsTimeBound = false;
            newSurveyVersion3.MaxUsers = 1000;
            newSurveyVersion3.MinUsers = 200;
            newSurveyVersion3.Status = "CLOSED";
            newSurveyVersion3.Questions = new List<Question>();

            SurveyVersion newSurveyVersion4 = new SurveyVersion();
            newSurveyVersion4.CreatedDate = DateTime.Now;
            newSurveyVersion4.IsTimeBound = false;
            newSurveyVersion4.MaxUsers = 1000;
            newSurveyVersion4.MinUsers = 200;
            newSurveyVersion4.Status = "CLOSED";
            newSurveyVersion4.Questions = new List<Question>();


            newSurvey.SurveyVersions.Add(newSurveyVersion1);
            newSurvey.SurveyVersions.Add(newSurveyVersion2);
            newSurvey.SurveyVersions.Add(newSurveyVersion3);
            newSurvey.SurveyVersions.Add(newSurveyVersion4);

            SingleSelect newQuestion = new SingleSelect();
            newQuestion.Description = "Single select inserted";
            newQuestion.Rating = 7;

            MultiSelect Question = new MultiSelect();
            Question.Description = "Multi select inserted";
            Question.MaxSelection = 2;

            newSurvey.SurveyVersions[0].Questions.Add(newQuestion);
            newSurvey.SurveyVersions[0].Questions.Add(Question);
            var json = new JavaScriptSerializer().Serialize(newSurvey);
            var test = surveyCtrl.CreateOrUpdate(newSurvey);

            Assert.IsNotNull(test);
        }
    }

    
}
