using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class BeneficiaryStatus
    {
        public BeneficiaryStatus()
        {
            Beneficiaries = new HashSet<Beneficiaries>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Beneficiaries> Beneficiaries { get; set; }
    }
}
