using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.Models
{
    public partial class Receipts
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public bool Active { get; set; }
        public string Observation { get; set; }

        public Bills Bill { get; set; }
    }
}
