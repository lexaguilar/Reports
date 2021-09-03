using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class AreaServices
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int ServiceId { get; set; }

        public Areas Area { get; set; }
        public Services Service { get; set; }
    }
}
