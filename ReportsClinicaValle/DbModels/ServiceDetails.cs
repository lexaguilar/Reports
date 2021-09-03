using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class ServiceDetails
    {
        public ServiceDetails()
        {
            ServiceTestDetails = new HashSet<ServiceTestDetails>();
        }

        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string Um { get; set; }
        public string Reference { get; set; }

        public ICollection<ServiceTestDetails> ServiceTestDetails { get; set; }
    }
}
