namespace AppQuanLy.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Purchase
    {
        public long ID { get; set; }

        public long Creater { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Status { get; set; }

        public decimal TotalPrice { get; set; }

        public int Publisher { get; set; }

    }
}
