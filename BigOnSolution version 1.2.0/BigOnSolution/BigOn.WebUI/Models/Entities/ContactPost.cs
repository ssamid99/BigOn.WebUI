using BigOn.WebUI.AppCode.Infracture;
using System;
using System.ComponentModel.DataAnnotations;

namespace BigOn.WebUI.Models.Entities
{
    public class ContactPost : BaseEntity
    {
        [Required(ErrorMessage ="{0} doldurulmalidir")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
       
        public string Answer { get; set; }
        public int? AnsweredByUserId { get; set; }
        public DateTime? AnswerDate { get; set; }

    }
}
