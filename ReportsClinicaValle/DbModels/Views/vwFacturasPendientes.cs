using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinicavalle.DbModels.Clinica
{
    public class vwFacturasPendientes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public decimal Deuda { get; set; }
    }
}
