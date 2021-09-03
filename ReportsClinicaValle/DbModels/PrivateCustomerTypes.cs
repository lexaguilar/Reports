using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class PrivateCustomerTypes
    {
        public PrivateCustomerTypes()
        {
            PrivateCustomers = new HashSet<PrivateCustomers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PrivateCustomers> PrivateCustomers { get; set; }
    }
}
