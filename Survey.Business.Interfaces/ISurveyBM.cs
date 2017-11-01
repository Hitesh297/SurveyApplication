
using SurveyAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAPI.Business.Interfaces
{
    public interface ISurveyBM
    {
        List<Survey> Get();
        Survey Create(Survey survey);
    }
}
