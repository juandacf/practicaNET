using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CategoriesCatalog : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryOptions> CategoryOptions { get; set; } = new List<CategoryOptions>();
        public List<OptionQuestions> OptionQuestions { get; set; } = new List<OptionQuestions>();
    }
}