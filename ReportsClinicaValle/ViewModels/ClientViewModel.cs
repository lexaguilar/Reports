using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsClinicaValle.ViewModels
{
    public class ClientViewModel
    {
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public decimal Deuda { get; set; }
        public DateTime? Nacimiento { get; set; }
    }
}
