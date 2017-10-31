using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAPI.Entities
{
    public class Survey
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual IList<SurveyVersion> SurveyVersions { get; set; }
    }
}
