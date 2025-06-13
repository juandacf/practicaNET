using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Questions: BaseEntity
    {
        public int Id { get; set; }
        public string QuestionNumber { get; set; }
        public string ResponseType { get; set; }
        public string CommentQuestion { get; set; }
        public string QuestionText { get; set; }

        public List<OptionQuestions> OptionQuestions { get; set; } = new List<OptionQuestions>();
        public List<SubQuestions> SubQuestions { get; set; } = new List<SubQuestions>();
        public List<SumaryOptions> SumaryOptions { get; set; } = new List<SumaryOptions>();

        public int ChapterId { get; set; }
    }
}