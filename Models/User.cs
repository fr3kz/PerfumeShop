using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace PerfumeShop.Models
{
    public class User : IdentityUser
    {
        

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

 
    }
}