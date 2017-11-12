
using SurveyAPI.Business;
using SurveyAPI.Business.Interfaces;
using SurveyAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SurveyAPI.Controllers
{
    [RoutePrefix("api/v1")]
    public class SurveyController : ApiController
    {
        private ISurveyBM surveyBM;
        public SurveyController()
        {
            surveyBM = new SurveyBM(); 
        }
        [Route("Surveys")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<Survey> surveys = surveyBM.Get();
            return Ok(surveys);
        }

        [Route("Survey/CreateOrUpdate")]
        [HttpPost]
        public IHttpActionResult CreateOrUpdate([FromBody]Survey survey)
        {
            var test = surveyBM.CreateOrUpdate(survey);
            return Ok(test);
        }

        [Route("Survey/Search")]
        [HttpGet]
        public IHttpActionResult Search([FromBody]SearchSurveys searchSurveys)
        {
            var test = surveyBM.Search(searchSurveys);
            return Ok(test);
        }
    }
}
