﻿using BigOn.WebUI.AppCode.Infracture;
using System.ComponentModel.DataAnnotations;

namespace BigOn.WebUI.Models.Entities
{
    public class Faq : BaseEntity
    {
        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer { get; set; }

    }
}
