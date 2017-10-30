
using NHibernate;
using SurveyAPI.Entities;
using SurveyBM.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAPI.Repository
{
    public class SurveyRepository : ISurveyRepository
    {
        public List<Survey> Get()
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.CreateCriteria<Survey>().List<Survey>().ToList();
        }
    }
}
