using BigOn.WebUI.AppCode.Infracture;
using System.Collections.Generic;

namespace BigOn.WebUI.Models.Entities
{
    public class ProductColor : BaseEntity
    {
        public string Name { get; set; }
        public string Hex { get; set; }
        public virtual ICollection<ProductCatalogItem> ProductCatalog { get; set; }


    }
}
