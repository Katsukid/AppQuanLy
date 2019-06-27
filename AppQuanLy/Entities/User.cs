namespace AppQuanLy.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? DayOfBirth { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public bool Status { get; set; }

        [StringLength(20)]
        public string GroupID { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
