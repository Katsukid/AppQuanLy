namespace AppQuanLy.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
          public long ID { get; set; }

          [StringLength(250)]
          public string Title { get; set; }

          public long? Created { get; set; }

          public DateTime? CreatedDate { get; set; }

          public long? Type { get; set; }

          public bool? isPublic { get; set; }

          public string Image { get; set; }

          public string Author { get; set; }

          public string Content { get; set; }

     }
}
