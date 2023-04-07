using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada2Api.Models
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }
        public string Concepto { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int MecanicoId { get; set; }

        [ForeignKey("ClienteId")]
        public Clientes clientes { get; set; }

        [ForeignKey("MecanicoId")]
        public Mecanicos mecanicos { get; set; }
    }
}
