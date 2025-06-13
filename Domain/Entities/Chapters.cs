using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Chapters:BaseEntity
    {
        public int Id { get; set; }
        public string ComponentHtml { get; set; }
        public string ComponentReact { get; set; }
        public string ChapterNumber { get; set; }
        public string ChapterTitle { get; set; }

        public List<Questions> Questions { get; set; } = new List<Questions>();
        public int SurveyId { get; set; }
        public Surveys Surveys { get; set; }
    }
}