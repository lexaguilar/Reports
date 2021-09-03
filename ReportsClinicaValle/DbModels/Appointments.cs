using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Appointments
    {
        public int Id { get; set; }
        public int Inss { get; set; }
        public int BeneficiaryId { get; set; }
        public int? AreaId { get; set; }
        public int SpecialtyId { get; set; }
        public int DoctorId { get; set; }
        public DateTime DateAppointment { get; set; }
        public string Observation { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public bool Active { get; set; }
        public string Identification { get; set; }

        public Areas Area { get; set; }
        public Beneficiaries Beneficiary { get; set; }
        public Users CreateByNavigation { get; set; }
        public Doctors Doctor { get; set; }
        public Specialties Specialty { get; set; }
    }
}
