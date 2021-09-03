using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class ServiceTestCultives
    {
        public ServiceTestCultives()
        {
            ServiceTestCultiveAntiBiotics = new HashSet<ServiceTestCultiveAntiBiotics>();
            ServiceTestCultiveFrescs = new HashSet<ServiceTestCultiveFrescs>();
        }

        public int Id { get; set; }
        public int ServiceTestId { get; set; }
        public int ServiceId { get; set; }
        public DateTime? TestDate { get; set; }
        public string Name { get; set; }
        public string Gram { get; set; }
        public string Isolated { get; set; }
        public int? Aminas { get; set; }
        public string Observation { get; set; }
        public string Mycologycal { get; set; }

        public Services Service { get; set; }
        public ServiceTests ServiceTest { get; set; }
        public ICollection<ServiceTestCultiveAntiBiotics> ServiceTestCultiveAntiBiotics { get; set; }
        public ICollection<ServiceTestCultiveFrescs> ServiceTestCultiveFrescs { get; set; }
    }
}
