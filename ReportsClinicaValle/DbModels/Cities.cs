using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Cities
    {
        public Cities()
        {
            Beneficiaries = new HashSet<Beneficiaries>();
        }

        public int Id { get; set; }
        public int RegionId { get; set; }
        public string Name { get; set; }

        public ICollection<Beneficiaries> Beneficiaries { get; set; }
    }
}
