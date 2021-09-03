using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Resources
    {
        public Resources()
        {
            RolResources = new HashSet<RolResources>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RolResources> RolResources { get; set; }
    }
}
