using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CategoryOptions: BaseEntity
    {
        public int Id { get; set; }
        public int CatalogOptionsId { get; set; }
        public int CategoriesOptionsId { get; set; }
        public int OptionsResponseId { get; set; }
        public OptionsResponse OptionsResponse { get; set; }
        public int CategoriesCatalogId { get; set; }
        public CategoriesCatalog CategoriesCatalog { get; set; }
    }
}