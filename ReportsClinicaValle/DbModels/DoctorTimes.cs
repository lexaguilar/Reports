using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class DoctorTimes
    {
        public int DoctorId { get; set; }
        public string Days { get; set; }
        public DateTime StartHour { get; set; }
        public int CountBeneficiarios { get; set; }
        public int TimeMinutesForBeneficiary { get; set; }

        public Doctors Doctor { get; set; }
    }
}
