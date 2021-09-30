using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinicavalle.DbModels.Clinica
{
    public class vwIntentario
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public int TypeId{ get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Stock { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }
}
