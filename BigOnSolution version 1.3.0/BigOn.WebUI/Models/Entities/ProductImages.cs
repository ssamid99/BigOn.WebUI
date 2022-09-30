using BigOn.WebUI.AppCode.Infracture;
using BigOn.WebUI.Models.DataContents;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;

namespace BigOn.WebUI.Models.Entities
{
    public class ProductImages : BaseEntity
    {
        public string Name { get; set; }    
        public bool IsMain { get; set; }
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }
    }
}
