using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAPI.Entities
{
    public class SurveyVersion
    {
        public int Id { get; set; }
        public bool IsTimeBound { get; set; }
        public int MaxUsers { get; set; }
        public int MinUsrs { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
