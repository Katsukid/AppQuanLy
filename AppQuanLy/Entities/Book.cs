namespace AppQuanLy.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Book
    {
          public long ID { get; set; }

          [StringLength(50)]
          public string Code { get; set; }

          [StringLength(250)]
          public string Name { get; set; }

          public int? Author { get; set; }

          public int? Released { get; set; }

          public int? Publisher { get; set; }

          public int? NumberPage { get; set; }

          public int? Weight { get; set; }

          [StringLength(20)]
          public string Form { get; set; }

          [Column(TypeName = "date")]
          public DateTime? PublishDate { get; set; }

          public int? Buys { get; set; }

          public decimal? Price { get; set; }

          public decimal? PromotionPrice { get; set; }

          public long? CategoryID { get; set; }

          public int? ViewCount { get; set; }

          public int? Inventory { get; set; }

          public bool? Status { get; set; }

          [StringLength(250)]
          public string Image { get; set; }

          public string Description { get; set; }

          public DateTime? ModifiedDate { get; set; }

          [StringLength(50)]
          public string ModifiedBy { get; set; }

     }
}
