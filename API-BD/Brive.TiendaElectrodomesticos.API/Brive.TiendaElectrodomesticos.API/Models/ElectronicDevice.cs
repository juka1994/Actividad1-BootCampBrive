using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.TiendaElectrodomesticos.API.Models
{
    [Table("ElectronicDevice")]
    public class ElectronicDevice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("Marca")]
        public string Marca { get; set; }
        [Column("Color")]
        public string Color { get; set; }
        [Column("Precio")]
        public decimal Precio { get; set; }
        [Column("Descripcion")]
        public string Descripcion { get; set; }

    }
}
