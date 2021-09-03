using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class FollowsPrivates
    {
        public FollowsPrivates()
        {
            PrivateWorkOrders = new HashSet<PrivateWorkOrders>();
        }

        public int Id { get; set; }
        public int BillId { get; set; }
        public int AreaSourceId { get; set; }
        public int AreaTargetId { get; set; }
        public string Observation { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }

        public Areas AreaSource { get; set; }
        public Areas AreaTarget { get; set; }
        public Bills Bill { get; set; }
        public ICollection<PrivateWorkOrders> PrivateWorkOrders { get; set; }
    }
}
