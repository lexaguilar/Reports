using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinicavalle.DbModels.Clinica
{
    public class vwValoracionAlmacen
    {
        [Key]
        public string Tipo{ get; set; }
        public double Recuento { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenta { get; set; }
    }
}
