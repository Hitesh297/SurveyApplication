using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAPI.Entities
{
    public class SurveyVersion
    {
        public virtual int Id { get; set; }
        public virtual bool IsTimeBound { get; set; }
        public virtual int MaxUsers { get; set; }
        public virtual int MinUsers { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual Survey Survey { get; set; }
        public virtual IList<Question> Questions { get; set; }
    }
}
