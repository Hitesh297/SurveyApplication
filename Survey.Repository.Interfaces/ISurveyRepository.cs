using SurveyAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBM.Repository.Interfaces
{
    public interface ISurveyRepository
    {
        List<Survey> Get();
    }
}
