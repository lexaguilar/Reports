using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinicavalle.DbModels.Clinica
{
    public class vwItems
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Date{ get; set; }
        public string Name{ get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Import { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
    }
}
