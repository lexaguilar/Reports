using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class ServiceTestBaarDetails
    {
        public int Id { get; set; }
        public int ServiceTestId { get; set; }
        public int ServiceId { get; set; }
        public DateTime? TestDate { get; set; }
        public int TestNumber { get; set; }
        public string Appearance { get; set; }
        public string ObservationBk { get; set; }
        public string Observation { get; set; }
        public string AppearanceBio { get; set; }

        public Services Service { get; set; }
        public ServiceTests ServiceTest { get; set; }
    }
}
