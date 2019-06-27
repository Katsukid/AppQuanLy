using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanLy.Entities;
using AppQuanLy.Helper;
namespace AppQuanLy.DAO
{
     public class AuthorTypeDao
     {

          public static AuthorType Take(int id)
          {
               return JSONHelper.SendGetRequest<AuthorType>("authortype/" + id);
          }
          public static List<AuthorType> TakeAll()
          {
               return JSONHelper.SendGetRequest<List<AuthorType>>("authortype?number");
          }
     }
}
