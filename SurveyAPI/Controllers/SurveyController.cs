
using SurveyAPI.Business;
using SurveyAPI.Business.Interfaces;
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
            var test = surveyBM.Get();
            return Ok(test);
        }

        [Route("Survey/Create")]
        [HttpGet]
        public IHttpActionResult Create()
        {
            var test = surveyBM.Get();
            return Ok(test);
        }
    }
}
