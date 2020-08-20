namespace WebSiteBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("aaaa")]
    public partial class aaaa
    {
        [Key]
        [StringLength(10)]
        public string dsa { get; set; }

        [Column("aaaa")]
        [StringLength(10)]
        public string aaaa1 { get; set; }
    }
}
