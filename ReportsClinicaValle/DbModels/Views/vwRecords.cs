using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinicavalle.DbModels.Clinica
{
    public class vwRecords
    {
        [Key]
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public string Axis { get; set; }
        public string Cylinder { get; set; }
        public string Sphere { get; set; }
        public string AVSC { get; set; }
        public string Addition { get; set; }
        public string Eye { get; set; }
    }

}
