using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class BillDetails
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int? ServiceId { get; set; }
        public int? ProductId { get; set; }
        public bool IsService { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public Bills Bill { get; set; }
        public Products Product { get; set; }
        public Services Service { get; set; }
    }
}
