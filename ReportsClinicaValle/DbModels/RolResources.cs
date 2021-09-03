using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class RolResources
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public int ResourceId { get; set; }
        public int Action { get; set; }

        public Resources Resource { get; set; }
        public Rols Rol { get; set; }
    }
}
