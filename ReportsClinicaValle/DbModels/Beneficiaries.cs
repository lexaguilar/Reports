using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Beneficiaries
    {
        public Beneficiaries()
        {
            Admissions = new HashSet<Admissions>();
            Appointments = new HashSet<Appointments>();
            Subsidies = new HashSet<Subsidies>();
        }

        public int Id { get; set; }
        public int Inss { get; set; }
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
        public int BeneficiaryStatusId { get; set; }
        public bool UpdateWithPercapita { get; set; }
        public int RelationshipId { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime? LastDateModificationAt { get; set; }
        public string LastModificationBy { get; set; }

        public BeneficiaryStatus BeneficiaryStatus { get; set; }
        public Cities City { get; set; }
        public Customers InssNavigation { get; set; }
        public Regions Region { get; set; }
        public Relationships Relationship { get; set; }
        public Sexs Sex { get; set; }
        public ICollection<Admissions> Admissions { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<Subsidies> Subsidies { get; set; }
    }
}
