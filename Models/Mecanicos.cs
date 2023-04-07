using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada2Api.Models
{
    public class Mecanicos
    {
        [Key]
        public int MecanicoId { get; set; }
        public string Nombres { get; set; }
        public string Area { get; set; }
        public string Telefono { get; set; }
        public int Disponible { get; set; } = 0;
    }
}
