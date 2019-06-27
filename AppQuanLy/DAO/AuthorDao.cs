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
               var type = AuthorTypeDao.Take((int)author.AuthorType);
               return new AuthorViewModel(author,type);
          }
          public static List<AuthorViewModel> TakeAllView(int? number)
          {
               var authors = TakeAll(number);
               var types = AuthorTypeDao.TakeAll();
               var ls = (from a in authors
                         join b in types
                         on a.AuthorType equals b.ID
                         select new AuthorViewModel(a, b)).ToList();
               return ls;
          }
     }
}
