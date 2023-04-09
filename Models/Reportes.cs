
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada2Api.Models
{
    public class Reportes
    {
        [Key]
        public int ReporteId { get; set; }
        public string Concepto { get; set; }
        public string Fecha { get; set; } 
        public int ClienteId { get; set; }
        public int MecanicoId { get; set; }

    }
}