using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AppQuanLy.Entities;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AppQuanLy.Helper
{
     class JSONHelper
     {
          private static readonly string url = "http://localhost:10744/";
          private static readonly string restfull = url + "api/";
          // GET
          public static T SendGetRequest<T>(string path)
          {
               T data = default(T);
               using (var client = new HttpClient())
               {
                    var req = client.GetAsync(restfull + path);
                    HttpResponseMessage res = req.Result;
                    var result = res.Content.ReadAsStringAsync().Result;
                    if (res.IsSuccessStatusCode)
                    {
                         data = JsonConvert.DeserializeObject<T>(result);
                    }
               }
               return data;
          }
          // POST
          public static bool SendPostRequest<T>(string path, T p)
          {
               bool objectOut = false;
               using (var client = new HttpClient())
               {
                    var data = JsonConvert.SerializeObject(p);
                    var httpContent = new StringContent(data, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(restfull);
                    var res = client.PostAsync(path, httpContent).Result;
                    if (res.IsSuccessStatusCode)
                    {
                         var result = res.Content.ReadAsStringAsync().Result;
                         objectOut = JsonConvert.DeserializeObject<bool>(result);
                    }
               }
               return objectOut;
          }
          // PUT
          public static T SendPutRequest<T>(string path, T p)
          {
               T objectOut = default(T);
               using (var client = new HttpClient())
               {
                    var data = JsonConvert.SerializeObject(p);
                    var httpContent = new StringContent(data, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(restfull);
                    var res = client.PutAsync(path, httpContent).Result;
                    if (res.IsSuccessStatusCode)
                    {
                         var result = res.Content.ReadAsStringAsync().Result;
                         objectOut = JsonConvert.DeserializeObject<T>(result);
                         return objectOut;
                    }
               }
               return objectOut;
          }
          // DELETE
          public static bool SendDeleteRequest(string path, int id)
          {
               bool objectOut = false;
               using (var client = new HttpClient())
               {
                    client.BaseAddress = new Uri(restfull);
                    var res = client.DeleteAsync(path + id).Result;
                    if (res.IsSuccessStatusCode)
                    {
                         var result = res.Content.ReadAsStringAsync().Result;
                         objectOut = JsonConvert.DeserializeObject<bool>(result);
                         return objectOut;
                    }
               }
               return objectOut;
          }
          public static bool SendDeleteRequest(string path, long id)
          {
               bool objectOut = false;
               using (var client = new HttpClient())
               {
                    client.BaseAddress = new Uri(restfull);
                    var res = client.DeleteAsync(path + id).Result;
                    if (res.IsSuccessStatusCode)
                    {
                         var result = res.Content.ReadAsStringAsync().Result;
                         objectOut = JsonConvert.DeserializeObject<bool>(result);
                         return objectOut;
                    }
               }
               return objectOut;
          }
          public static bool SendDeleteRequest(string path)
          {
               bool objectOut = false;
               using (var client = new HttpClient())
               {
                    client.BaseAddress = new Uri(restfull);
                    var res = client.DeleteAsync(path).Result;
                    if (res.IsSuccessStatusCode)
                    {
                         var result = res.Content.ReadAsStringAsync().Result;
                         objectOut = JsonConvert.DeserializeObject<bool>(result);
                         return objectOut;
                    }
               }
               return objectOut;
          }
          //string json = JsonConvert.SerializeObject(new List<somemodel> { new somemodel() });
          //StringContent sc = new StringContent(json, Encoding.UTF8, "application/json");

          //HttpClient c = new HttpClient(new HttpClientHandler { UseDefaultCredentials = true });
          //var x = c.PostAsync("http://localhost:58893/api/values?additionalParam=" + "test", sc).Result; // returns 200
          //public static bool SendPostRequest<T>(string path, T p)
          //{
          //     bool objectOut = false;
          //     using (var client = new HttpClient())
          //     {
          //          var data = new StringContent(JsonConvert.SerializeObject(p));
          //          data.Headers.ContentType = new MediaTypeHeaderValue("application/json");
          //          client.BaseAddress = new Uri(restfull);
          //          var res = client.PostAsync(path, data).Result;
          //          if (res.IsSuccessStatusCode)
          //          {
          //               var result = res.Content.ReadAsStringAsync().Result;
          //               objectOut = JsonConvert.DeserializeObject<bool>(result);
          //               return objectOut;
          //          }
          //     }
          //     return objectOut;
          //}
     }
}
