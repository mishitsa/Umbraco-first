using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace asdds.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Enter ur name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter ur email")]
        [EmailAddress(ErrorMessage = "u must enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter ur message")]
        [MaxLength(500, ErrorMessage = "Ur message must be no longer than 500 characters")]
        public string Message { get; set; }

        public int ContactFormId { get; set; }
    }
}