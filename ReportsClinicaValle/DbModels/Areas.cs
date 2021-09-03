using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Areas
    {
        public Areas()
        {
            Admissions = new HashSet<Admissions>();
            Appointments = new HashSet<Appointments>();
            AreaProductStocks = new HashSet<AreaProductStocks>();
            AreaServices = new HashSet<AreaServices>();
            Bills = new HashSet<Bills>();
            FollowsAreaSource = new HashSet<Follows>();
            FollowsAreaTarget = new HashSet<Follows>();
            FollowsPrivatesAreaSource = new HashSet<FollowsPrivates>();
            FollowsPrivatesAreaTarget = new HashSet<FollowsPrivates>();
            InPutProducts = new HashSet<InPutProducts>();
            OutPutProducts = new HashSet<OutPutProducts>();
            Subsidies = new HashSet<Subsidies>();
            TraslatesAreaSource = new HashSet<Traslates>();
            TraslatesAreaTarget = new HashSet<Traslates>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public ICollection<Admissions> Admissions { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<AreaProductStocks> AreaProductStocks { get; set; }
        public ICollection<AreaServices> AreaServices { get; set; }
        public ICollection<Bills> Bills { get; set; }
        public ICollection<Follows> FollowsAreaSource { get; set; }
        public ICollection<Follows> FollowsAreaTarget { get; set; }
        public ICollection<FollowsPrivates> FollowsPrivatesAreaSource { get; set; }
        public ICollection<FollowsPrivates> FollowsPrivatesAreaTarget { get; set; }
        public ICollection<InPutProducts> InPutProducts { get; set; }
        public ICollection<OutPutProducts> OutPutProducts { get; set; }
        public ICollection<Subsidies> Subsidies { get; set; }
        public ICollection<Traslates> TraslatesAreaSource { get; set; }
        public ICollection<Traslates> TraslatesAreaTarget { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
