using BigOn.WebUI.AppCode.Infracture;
using System.Collections;
using System.Collections.Generic;

namespace BigOn.WebUI.Models.Entities
{
    public class ProductMaterial : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ProductCatalogItem> ProductCatalog { get; set; }
    }
}
