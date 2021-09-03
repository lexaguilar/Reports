using System;
using System.Collections.Generic;

namespace ReportsSora.Models
{
    public partial class Apps
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slogan { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Website { get; set; }
        public int DefaultCurrency { get; set; }
        public int? Decimals { get; set; }
        public bool ValidatePriceGreaterCost { get; set; }
        public int AreaMainId { get; set; }
        public decimal? Iva { get; set; }
        public int? ClientDefault { get; set; }
        public bool? UseCode { get; set; }
        public int? InitCode { get; set; }
        public int? EndCode { get; set; }
        public byte[] SerieNumber { get; set; }
        public int? CommissionType { get; set; }
        public string CalculateCommission { get; set; }
        public int CommissionPercent { get; set; }
    }
}
