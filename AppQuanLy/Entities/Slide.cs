namespace AppQuanLy.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class Slide
    {
        public int ID { get; set; }

        public long Image { get; set; }

        public int? DisplayOrder { get; set; }

        public long? BookID { get; set; }

        [StringLength(255)]
        public string Link { get; set; }

        public bool Status { get; set; }

        public DateTime? CreatedDate { get; set; }

    }
}
