using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsSora.ViewModels
{
    public class ProductsInfo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Factura { get; set; }
        public string Referencia { get; set; }
        public double Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total{ get; set; }
    }
}
