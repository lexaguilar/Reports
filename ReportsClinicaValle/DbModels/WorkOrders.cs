using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class WorkOrders
    {
        public WorkOrders()
        {
            WorkOrderDetails = new HashSet<WorkOrderDetails>();
        }

        public int Id { get; set; }
        public int FollowId { get; set; }
        public DateTime Date { get; set; }
        public string Observation { get; set; }
        public string Reference { get; set; }
        public int DoctorId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }

        public Doctors Doctor { get; set; }
        public Follows Follow { get; set; }
        public ICollection<WorkOrderDetails> WorkOrderDetails { get; set; }
    }
}
