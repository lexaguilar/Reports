using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Contracts
    {
        public Contracts()
        {
            PrivateCustomers = new HashSet<PrivateCustomers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public ICollection<PrivateCustomers> PrivateCustomers { get; set; }
    }
}
