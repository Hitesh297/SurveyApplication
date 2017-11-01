using SurveyAPI.Business.Interfaces;
using SurveyAPI.Entities;
using SurveyAPI.Repository;
using SurveyBM.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAPI.Business
{
    public class SurveyBM : ISurveyBM
    {
        ISurveyRepository surveyRepository;
        public SurveyBM()
        {
            surveyRepository = new SurveyRepository();
        }
        public List<Survey> Get()
        {
            return surveyRepository.Get();
        }

        public Survey Create(Survey survey)
        {
            return surveyRepository.Create(survey);
        }
    }
}
