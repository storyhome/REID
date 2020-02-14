using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REID.APPL.Models
{
    public class ContactViewModel
    { [Required]
      [MinLength(3)]
      public string Name { get; set;}
      [Required]
      [EmailAddress]
      public string Email { get; set; }
      [Required]
        public string Subject { get; set; }
      [Required]
      [MaxLength(1000, ErrorMessage = "Your messsage is too long")]
        public string Message { get; set; }
    }
}
