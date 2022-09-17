using BigOn.WebUI.AppCode.Infracture;
using System.Collections.Generic;

namespace BigOn.WebUI.Models.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }    
        public int ProductColorId { get; set; }
        public virtual ICollection<ProductColor> ProductColors { get; set; }
        public int ProductSizeId { get; set; }
        public virtual ICollection<ProductSize> ProductSizes { get; set; }
        public int ProductMaterialId { get; set; }
        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }
    }
}
