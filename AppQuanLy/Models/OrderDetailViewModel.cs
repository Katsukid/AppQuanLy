using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppQuanLy.Entities;
namespace AppQuanLy.Models
{
     public class OrderDetailViewModel
     {
          public Order_Detail orderdetail { get; set; }
          public Book book { get; set; }
     }
}