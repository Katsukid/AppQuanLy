namespace AppQuanLy.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookCategory
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public long? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreateDate { get; set; }

    }
}
