using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsClinicaValle.ViewModels
{
    public class BillsViewModels
    {
        public string Factura { get; set; }
        public string Referencia{ get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente{ get; set; }
        public decimal SubTotal{ get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string CreateBy { get; set; }
    }
}
