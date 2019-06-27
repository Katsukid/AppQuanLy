namespace AppQuanLy.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class PurchaseDetail
    {
          public long ID { get; set; }

          public long PurchaseID { get; set; }

          public long BookID { get; set; }

          public int Quantity { get; set; }

          public decimal Price { get; set; }
     }
}
