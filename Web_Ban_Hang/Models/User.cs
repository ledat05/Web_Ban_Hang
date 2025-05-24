using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Ban_Hang.Models
{
    public class User : Controller
    {
      public int id { get; set; }
      public string Name { get; set; }
      public string Email { get; set; }
      public string Password { get; set; }
      public string PhoneNumber { get; set; }

    }
}
