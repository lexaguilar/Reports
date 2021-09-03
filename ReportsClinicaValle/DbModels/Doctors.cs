using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Doctors
    {
        public Doctors()
        {
            Appointments = new HashSet<Appointments>();
            PrivateWorkOrders = new HashSet<PrivateWorkOrders>();
            SendTests = new HashSet<SendTests>();
            ServiceTests = new HashSet<ServiceTests>();
            Subsidies = new HashSet<Subsidies>();
            WorkOrders = new HashSet<WorkOrders>();
            WorkPreOrders = new HashSet<WorkPreOrders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string MinsaCode { get; set; }
        public int SpecialtyId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }

        public Specialties Specialty { get; set; }
        public DoctorTimes DoctorTimes { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<PrivateWorkOrders> PrivateWorkOrders { get; set; }
        public ICollection<SendTests> SendTests { get; set; }
        public ICollection<ServiceTests> ServiceTests { get; set; }
        public ICollection<Subsidies> Subsidies { get; set; }
        public ICollection<WorkOrders> WorkOrders { get; set; }
        public ICollection<WorkPreOrders> WorkPreOrders { get; set; }
    }
}
