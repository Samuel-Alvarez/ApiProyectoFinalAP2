using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada2Api.Models
{
    public class Vehiculos
    {
        [Key]
        public int VehiculoId { get; set; }
        public string Marca { set; get; }
        public string Modelo { set; get; }
        public string year { set; get; }
    }
}