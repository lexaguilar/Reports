using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class InPutProductDetails
    {
        public int Id { get; set; }
        public int InPutProductId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Import { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public decimal CostAvg { get; set; }
        public double Stocks { get; set; }

        public InPutProducts InPutProduct { get; set; }
        public Products Product { get; set; }
    }
}
