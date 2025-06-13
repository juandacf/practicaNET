using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SubQuestions:BaseEntity
    {
        public int Id { get; set; }
        public string SubquestionNumber { get; set; }
        public string CommentSubQuestion { get; set; }
        public string SubquestionText { get; set; }

        public List<OptionQuestions> OptionQuestions { get; set; } = new List<OptionQuestions>();

        public int QuestionId { get; set; }
        public Questions Questions { get; set; }
    }
}