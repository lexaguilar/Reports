using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Customers
    {
        public Customers()
        {
            Beneficiaries = new HashSet<Beneficiaries>();
        }

        public int Inss { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PatronalId { get; set; }
        public DateTime DateAdd { get; set; }
        public int CustomerStatusId { get; set; }
        public int CustomerTypeId { get; set; }
        public string Identification { get; set; }

        public CustomerStatus CustomerStatus { get; set; }
        public CustomerTypes CustomerType { get; set; }
        public ICollection<Beneficiaries> Beneficiaries { get; set; }
    }
}
