using BigOn.WebUI.AppCode.Infracture;
using System.Collections.Generic;

namespace BigOn.WebUI.Models.Entities
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; }
        public int? BrandId { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
    }
}
