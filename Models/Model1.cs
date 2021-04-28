using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LosaCrud.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Modelo1")
        {
        }

        public virtual DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>()
                .Property(e => e.pro_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.pro_descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.pro_precio)
                .HasPrecision(8, 2);
        }
    }
}
