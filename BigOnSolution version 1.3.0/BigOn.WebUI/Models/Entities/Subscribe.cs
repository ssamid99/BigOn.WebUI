﻿using BigOn.WebUI.AppCode.Infracture;
using System;
using System.ComponentModel.DataAnnotations;

namespace BigOn.WebUI.Models.Entities
{
    public class Subscribe :BaseEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime? ApproveDate { get; set; }
        public bool IsApproved { get; set; } = false; 


    }
}
