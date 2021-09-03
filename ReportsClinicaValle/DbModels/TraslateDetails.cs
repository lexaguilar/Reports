using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class TraslateDetails
    {
        public int Id { get; set; }
        public int TraslateId { get; set; }
        public int ProductId { get; set; }
        public double QuantityRequest { get; set; }
        public double QuantityResponse { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Import { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public decimal CostAvg { get; set; }
        public double Stocks { get; set; }

        public Products Product { get; set; }
        public Traslates Traslate { get; set; }
    }
}
