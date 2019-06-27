using AppQuanLy.Entities;
using AppQuanLy.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLy.DAO
{
     public class ImageDao
     {
          public static Image Take(int id)
          {
               return JSONHelper.SendGetRequest<Image>("image/" + id);
          }
          public static List<Image> TakeAll()
          {
               return JSONHelper.SendGetRequest<List<Image>>("image?number");
          }
     }
}
