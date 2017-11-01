using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAPI.Entities
{
    public class Question
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        //public virtual SurveyVersion SurveyVersion { get; set; }
    }

    public class SingleSelect : Question
    {
        public virtual int Rating { get; set; }
    }

    public class MultiSelect : Question
    {
        public virtual int MaxSelection { get; set; }
    }

    public class QuestionType
    {
        public virtual int Id { get; set; }
        public  virtual string Description { get; set; }
    }
}
