using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class ServiceTestCultiveAntiBiotics
    {
        public int Id { get; set; }
        public int ServiceTestCultiveId { get; set; }
        public string TestId { get; set; }
        public int ResultId { get; set; }

        public ServiceTestCultives ServiceTestCultive { get; set; }
    }
}
