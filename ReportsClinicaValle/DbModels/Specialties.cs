using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Specialties
    {
        public Specialties()
        {
            Admissions = new HashSet<Admissions>();
            Appointments = new HashSet<Appointments>();
            Doctors = new HashSet<Doctors>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public ICollection<Admissions> Admissions { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<Doctors> Doctors { get; set; }
    }
}
