using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Admissions
    {
        public Admissions()
        {
            Follows = new HashSet<Follows>();
        }

        public int Id { get; set; }
        public int NumberOfDay { get; set; }
        public int Inss { get; set; }
        public int BeneficiaryId { get; set; }
        public int AreaId { get; set; }
        public int SpecialtyId { get; set; }
        public string Cie10Id { get; set; }
        public bool Active { get; set; }
        public string Motive { get; set; }
        public int TypeId { get; set; }
        public string Observation { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public bool Finished { get; set; }
        public string Identification { get; set; }

        public Areas Area { get; set; }
        public Beneficiaries Beneficiary { get; set; }
        public Cie10 Cie10 { get; set; }
        public Users CreateByNavigation { get; set; }
        public Specialties Specialty { get; set; }
        public AdmissionTypes Type { get; set; }
        public ICollection<Follows> Follows { get; set; }
    }
}
