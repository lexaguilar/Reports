using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class WorkPreOrders
    {
        public WorkPreOrders()
        {
            WorkPreOrderDetails = new HashSet<WorkPreOrderDetails>();
        }

        public int Id { get; set; }
        public int FollowId { get; set; }
        public string Observation { get; set; }
        public int DoctorId { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public bool Used { get; set; }

        public Doctors Doctor { get; set; }
        public Follows Follow { get; set; }
        public ICollection<WorkPreOrderDetails> WorkPreOrderDetails { get; set; }
    }
}
