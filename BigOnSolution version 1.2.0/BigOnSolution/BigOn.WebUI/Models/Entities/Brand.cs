using BigOn.WebUI.AppCode.Infracture;
using System.Collections.Generic;

namespace BigOn.WebUI.Models.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }    
        public virtual ICollection<Product> Products { get; set; }
       
    }
}
