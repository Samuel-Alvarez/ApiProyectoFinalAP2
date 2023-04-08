using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada2Api.Models
{
    public class Solicitudes
    {
        [Key]
        public int SolicitudId { get; set; }
        public string Concepto { get; set; }
        public string Fecha { get; set; }
        public int ClienteId { get; set; }
        public int MecanicoId { get; set; }

        [ForeignKey("ClienteId")]
        public Clientes clientes { get; set; }

        [ForeignKey("MecanicoId")]
        public Mecanicos mecanicos { get; set; }


    }
}