using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Sexs
    {
        public Sexs()
        {
            Beneficiaries = new HashSet<Beneficiaries>();
            PrivateCustomers = new HashSet<PrivateCustomers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Beneficiaries> Beneficiaries { get; set; }
        public ICollection<PrivateCustomers> PrivateCustomers { get; set; }
    }
}
