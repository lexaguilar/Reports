using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class PrivateWorkOrders
    {
        public PrivateWorkOrders()
        {
            PrivateWorkOrderDetails = new HashSet<PrivateWorkOrderDetails>();
        }

        public int Id { get; set; }
        public int FollowsPrivateId { get; set; }
        public DateTime Date { get; set; }
        public string Observation { get; set; }
        public string Reference { get; set; }
        public int DoctorId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }

        public Doctors Doctor { get; set; }
        public FollowsPrivates FollowsPrivate { get; set; }
        public ICollection<PrivateWorkOrderDetails> PrivateWorkOrderDetails { get; set; }
    }
}
