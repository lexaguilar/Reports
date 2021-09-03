using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class CustomerTypes
    {
        public CustomerTypes()
        {
            Customers = new HashSet<Customers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Customers> Customers { get; set; }
    }
}
