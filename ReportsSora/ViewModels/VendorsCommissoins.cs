using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsSora.ViewModels
{
    public class VendorsCommissoins
    {
        public string Vendor { get; set; }
        public string FacturaId { get; set; }      
        public DateTime Date { get; set; }
        //Detalle
        public string Producto { get; set; }
        public double Cantidad { get; set; }
        public decimal Comision { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public string Descripcion { get; set; }
    }
   
 }
