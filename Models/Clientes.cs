using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada2Api.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Telefono { set; get; }
        public string Direccion { get; set; }
        public int VehiculoId { get; set; }

        [ForeignKey("VehiculoId")]
        public Vehiculos vehiculos { get; set; }
    }
}
