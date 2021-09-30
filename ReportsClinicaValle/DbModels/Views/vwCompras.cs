using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinicavalle.DbModels.Clinica
{
    public class vwCompras
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Import { get; set; }
        public decimal Discount { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public string Reference { get; set; }
        public int PaymentTypeId { get; set; }
        public string Provider { get; set; }

    }
}
