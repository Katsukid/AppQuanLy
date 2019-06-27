using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AppQuanLy.Entities;
using System.Net.Http;

namespace AppQuanLy.DAO
{
     class LoginDAO
     {
          private static string url = "http://localhost:1905/";
          private static string apiUrl = url + "api/";

          public static bool LoginRequest(string path, string user, string pass)
          {               
               bool objectOut = true;
               //using (var client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = true }))
               //{
               //     // Thiet lap dia chi server
               //     client.BaseAddress = new Uri(apiUrl);
               //     // Xay dung duong dan
               //     string query = path + "?username=" + user + "&password=" + pass;
               //     var res = client.PostAsync(query, null).Result;
               //     if (res.IsSuccessStatusCode)
               //     {
               //          var result = res.Content.ReadAsStringAsync().Result;
               //          objectOut = JsonConvert.DeserializeObject<bool>(result);
               //          return objectOut;
               //     }
               //}
               return objectOut;
          }
     }
}
