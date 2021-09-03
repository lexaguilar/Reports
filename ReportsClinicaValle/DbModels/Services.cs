using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Services
    {
        public Services()
        {
            AreaServices = new HashSet<AreaServices>();
            BillDetails = new HashSet<BillDetails>();
            PrivateWorkOrderDetails = new HashSet<PrivateWorkOrderDetails>();
            ServiceTestBaarDetails = new HashSet<ServiceTestBaarDetails>();
            ServiceTestCultives = new HashSet<ServiceTestCultives>();
            ServiceTestDetails = new HashSet<ServiceTestDetails>();
            WorkOrderDetails = new HashSet<WorkOrderDetails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PriceCalculate { get; set; }
        public bool Active { get; set; }
        public int CurrencyId { get; set; }
        public bool IsCultive { get; set; }

        public Currencies Currency { get; set; }
        public ICollection<AreaServices> AreaServices { get; set; }
        public ICollection<BillDetails> BillDetails { get; set; }
        public ICollection<PrivateWorkOrderDetails> PrivateWorkOrderDetails { get; set; }
        public ICollection<ServiceTestBaarDetails> ServiceTestBaarDetails { get; set; }
        public ICollection<ServiceTestCultives> ServiceTestCultives { get; set; }
        public ICollection<ServiceTestDetails> ServiceTestDetails { get; set; }
        public ICollection<WorkOrderDetails> WorkOrderDetails { get; set; }
    }
}
