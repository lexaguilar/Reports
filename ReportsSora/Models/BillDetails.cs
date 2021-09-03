using System;
using System.Collections.Generic;

namespace ReportsSora.Models
{
    public partial class BillDetails
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }
        public decimal Import { get; set; }
        public decimal Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public decimal Cost { get; set; }
        public decimal CustomPrice { get; set; }

        public Bills Bill { get; set; }
        public Products Product { get; set; }
    }
}
