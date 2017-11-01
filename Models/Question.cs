﻿using System;
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
        public virtual SurveyVersion SurveyVersion { get; set; }
    }
}
