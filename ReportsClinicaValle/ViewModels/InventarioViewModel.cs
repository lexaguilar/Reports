using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsClinicaValle.ViewModels
{
    public class InventarioViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Nombre { get; set; }
        public decimal PCompra { get; set; }
        public decimal IVA{ get; set; }
        public decimal PVP{ get; set; }
        public double Existencia{ get; set; }
    }
}
