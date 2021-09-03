using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class PrivateCustomers
    {
        public PrivateCustomers()
        {
            Bills = new HashSet<Bills>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Identification { get; set; }
        public int SexId { get; set; }
        public int RegionId { get; set; }
        public int CityId { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime? LastDateModificationAt { get; set; }
        public string LastModificationBy { get; set; }
        public int PrivateCustomerStatusId { get; set; }
        public int? Inss { get; set; }
        public int TypeId { get; set; }
        public int? ContractId { get; set; }

        public Contracts Contract { get; set; }
        public PrivateCustomerStats PrivateCustomerStatus { get; set; }
        public Sexs Sex { get; set; }
        public PrivateCustomerTypes Type { get; set; }
        public ICollection<Bills> Bills { get; set; }
    }
}
