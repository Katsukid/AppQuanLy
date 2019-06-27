namespace AppQuanLy.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Author
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string AuthorType { get; set; }
    }
}
