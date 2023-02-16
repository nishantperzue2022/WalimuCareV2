using System;
using System.Collections.Generic;
using System.Text;

namespace WalimuCareApp.Models
{
    public class Login
    {
        public Guid? Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
