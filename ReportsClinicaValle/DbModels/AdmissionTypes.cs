using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class AdmissionTypes
    {
        public AdmissionTypes()
        {
            Admissions = new HashSet<Admissions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Admissions> Admissions { get; set; }
    }
}
