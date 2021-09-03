using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class CustomerStatus
    {
        public CustomerStatus()
        {
            Customers = new HashSet<Customers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Customers> Customers { get; set; }
    }
}
