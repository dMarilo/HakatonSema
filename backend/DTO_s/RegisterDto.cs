using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DTO_s
{
    public class RegisterDto
    {
            public string Username { get; set; }
            public string Password { get; set; }
            
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            public DateOnly BirthDate { get; set; } 
            [Phone] // Optional phone number
            public string PhoneNumber { get; set; }
    }
}