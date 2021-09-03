using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class ServiceTestCultiveFrescs
    {
        public int Id { get; set; }
        public int ServiceTestCultiveId { get; set; }
        public string TestId { get; set; }
        public string ResultId { get; set; }

        public ServiceTestCultives ServiceTestCultive { get; set; }
    }
}
