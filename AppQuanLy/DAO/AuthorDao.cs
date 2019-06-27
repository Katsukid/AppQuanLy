using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanLy.Entities;
using AppQuanLy.Models;
using AppQuanLy.Helper;
namespace AppQuanLy.DAO
{
     public class AuthorDao
     {
          // Lay 1 phan tu
          public static Author Take(int id)
          {
               return JSONHelper.SendGetRequest<Author>("author/"+id);
          }
          // Lay nhieu phan tu
          public static List<Author> TakeAll(int? number)
          {
               return JSONHelper.SendGetRequest<List<Author>>("author?number=" + number);
          }          
          public static AuthorViewModel TakeView(int id)
          {
               var author = Take(id);
               return new AuthorViewModel(author);
          }
          public static List<AuthorViewModel> TakeAllView(int? number)
          {
               var authors = TakeAll(number);
               var ls = (from a in authors
                         select new AuthorViewModel(a)).ToList();
               return ls;
          }
     }
}
