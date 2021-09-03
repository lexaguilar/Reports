using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class WorkOrderDetails
    {
        public int Id { get; set; }
        public int WorkOrderId { get; set; }
        public int? ServiceId { get; set; }
        public int? ProductId { get; set; }
        public bool IsService { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Costo { get; set; }

        public Products Product { get; set; }
        public Services Service { get; set; }
        public WorkOrders WorkOrder { get; set; }
    }
}
