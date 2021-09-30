using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinicavalle.DbModels.Clinica
{
    public class vwBills
    {
        [Key]
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public string CreateBy { get; set; }
    }
}
