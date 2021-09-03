using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class ProviderStates
    {
        public ProviderStates()
        {
            Providers = new HashSet<Providers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Providers> Providers { get; set; }
    }
}
