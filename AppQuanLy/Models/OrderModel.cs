using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppQuanLy.Entities;

namespace AppQuanLy.Models
{
   public class OrderModel
    {
        public Order order { get; set; }
        public string TypeShip { get; set; }
        public string NameShipper { get; set; }
    }
}
