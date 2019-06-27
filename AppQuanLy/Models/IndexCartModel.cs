using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using AppQuanLy.Entities;
using AppQuanLy.Models;
namespace AppQuanLy.Models
{
     public class IndexCartModel
     {
          public decimal? totalPrice { get; set; }
          public decimal? totalPromotion { get; set; }
          public decimal? totalQuantity { get; set; }
          public List<BookViewModel> listHotBook { get; set; }
          public List<CartItemDetail> cart { get; set; }
     }
}