namespace AppQuanLy.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class CartItem
    {
          public long ID { get; set; }

          public long CustomerID { get; set; }

          public long ItemID { get; set; }

          public int? Quantity { get; set; }

          public DateTime? DateAdded { get; set; }

     }
}
