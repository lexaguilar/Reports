using System;
using System.Collections.Generic;

namespace ReportsSora.Models
{
    public partial class Clients
    {
        public Clients()
        {
            Bills = new HashSet<Bills>();
        }

        public int Id { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string Identification { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberWork { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public int? DepartmentId { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }
        public int? SexId { get; set; }
        public decimal CreditLimit { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifyAt { get; set; }
        public string ModifyBy { get; set; }
        public bool? IsCompany { get; set; }

        public ICollection<Bills> Bills { get; set; }
    }
}
