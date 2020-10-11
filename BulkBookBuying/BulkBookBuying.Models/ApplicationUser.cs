using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace BulkBookBuying.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        [NotMapped] 
        public string Role { get; set; }
  
    }
}
