using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLy.Models
{
     class LoginModel
     {
          private string Username { get; set; }
          private string Password { get; set; }
          public LoginModel(string usr,string pass)
          {
               this.Username = usr;
               this.Password = pass;
          }
     }
}
