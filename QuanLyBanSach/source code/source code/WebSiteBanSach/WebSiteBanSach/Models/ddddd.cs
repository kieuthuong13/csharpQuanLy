namespace WebSiteBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ddddd")]
    public partial class ddddd
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime da { get; set; }

        [StringLength(10)]
        public string d { get; set; }
    }
}
