using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class WorkPreOrderDetails
    {
        public int Id { get; set; }
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Costo { get; set; }
        public string Presentation { get; set; }
        public string Um { get; set; }

        public Products Product { get; set; }
        public WorkPreOrders WorkOrder { get; set; }
    }
}
