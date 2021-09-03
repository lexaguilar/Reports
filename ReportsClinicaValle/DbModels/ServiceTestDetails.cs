using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class ServiceTestDetails
    {
        public int Id { get; set; }
        public int ServiceTestId { get; set; }
        public int ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public string Name { get; set; }
        public string Um { get; set; }
        public string Reference { get; set; }
        public string Result { get; set; }
        public string ResultJson { get; set; }

        public Services Service { get; set; }
        public ServiceDetails ServiceDetail { get; set; }
        public ServiceTests ServiceTest { get; set; }
    }
}
