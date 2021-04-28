namespace LosaCrud.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos
    {
        [Key]
        public int pro_codigo { get; set; }

        [StringLength(50)]
        public string pro_nombre { get; set; }

        [StringLength(50)]
        public string pro_descripcion { get; set; }

        public decimal? pro_precio { get; set; }
    }
}
