namespace WebSiteBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dsadsa")]
    public partial class dsadsa
    {
        [Key]
        [StringLength(10)]
        public string dsa { get; set; }

        [StringLength(10)]
        public string dsads { get; set; }
    }
}
