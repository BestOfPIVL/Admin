using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginIn
{
    class Login
    {
        public Register[] registers { get; set; }
    }
    class Register
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Password_confirmation { get; set; }
        public string Status { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public string Admission_year { get; set; }
        public string Mail { get; set; }

    }
}
