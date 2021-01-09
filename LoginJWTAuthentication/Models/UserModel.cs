using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginJWTAuthentication.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string EmailAddress { get; internal set; }
    }
}
