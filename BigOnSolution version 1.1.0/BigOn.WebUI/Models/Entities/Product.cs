using BigOn.WebUI.AppCode.Infracture;
using System.Collections;
using System.Collections.Generic;

namespace BigOn.WebUI.Models.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? BrandId { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
    }
}
