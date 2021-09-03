using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class AreaProductStocks
    {
        public int AreaId { get; set; }
        public int ProductId { get; set; }
        public double Stock { get; set; }
        public decimal CostAvg { get; set; }
        public decimal CostReal { get; set; }
        public double Min { get; set; }
        public decimal Price { get; set; }
        public bool Inherit { get; set; }
        public double? StockMin { get; set; }

        public Areas Area { get; set; }
        public Products Product { get; set; }
    }
}
