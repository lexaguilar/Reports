using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Follows
    {
        public Follows()
        {
            SendTests = new HashSet<SendTests>();
            ServiceTests = new HashSet<ServiceTests>();
            WorkOrders = new HashSet<WorkOrders>();
            WorkPreOrders = new HashSet<WorkPreOrders>();
        }

        public int Id { get; set; }
        public int AdmissionId { get; set; }
        public int AreaSourceId { get; set; }
        public int AreaTargetId { get; set; }
        public string Observation { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }

        public Admissions Admission { get; set; }
        public Areas AreaSource { get; set; }
        public Areas AreaTarget { get; set; }
        public ICollection<SendTests> SendTests { get; set; }
        public ICollection<ServiceTests> ServiceTests { get; set; }
        public ICollection<WorkOrders> WorkOrders { get; set; }
        public ICollection<WorkPreOrders> WorkPreOrders { get; set; }
    }
}
