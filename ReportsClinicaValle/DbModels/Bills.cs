using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Bills
    {
        public Bills()
        {
            BillDetails = new HashSet<BillDetails>();
            FollowsPrivates = new HashSet<FollowsPrivates>();
        }

        public int Id { get; set; }
        public int BillTypeId { get; set; }
        public int AreaId { get; set; }
        public int PrivateCustomerId { get; set; }
        public decimal Total { get; set; }
        public string Observation { get; set; }
        public int CurrencyId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public decimal Rate { get; set; }
        public bool Finished { get; set; }
        public string NameCustomer { get; set; }

        public Areas Area { get; set; }
        public BillTypes BillType { get; set; }
        public Currencies Currency { get; set; }
        public PrivateCustomers PrivateCustomer { get; set; }
        public ICollection<BillDetails> BillDetails { get; set; }
        public ICollection<FollowsPrivates> FollowsPrivates { get; set; }
    }
}
