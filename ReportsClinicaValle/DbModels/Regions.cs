using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Regions
    {
        public Regions()
        {
            Beneficiaries = new HashSet<Beneficiaries>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Beneficiaries> Beneficiaries { get; set; }
    }
}
