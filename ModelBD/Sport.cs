namespace Kursovaya.ModelBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sport")]
    public partial class Sport
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string HallName { get; set; }

        [Required]
        [StringLength(50)]
        public string VadilityPeriod { get; set; }

        [Required]
        [StringLength(50)]
        public string Price { get; set; }
    }
}
