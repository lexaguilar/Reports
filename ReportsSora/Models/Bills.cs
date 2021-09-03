using System;
using System.Collections.Generic;

namespace ReportsSora.Models
{
    public partial class Bills
    {
        public Bills()
        {
            BillDetails = new HashSet<BillDetails>();
            Receipts = new HashSet<Receipts>();
        }

        public int Id { get; set; }
        public int AreaId { get; set; }
        public int ClientId { get; set; }
        public int PaymentTypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Import { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public decimal Rate { get; set; }
        public string Observation { get; set; }
        public int CreditDays { get; set; }
        public int? VendorId { get; set; }
        public bool Active { get; set; }
        public bool Payoff { get; set; }
        public int? PaymentMethodId { get; set; }
        public int? BankId { get; set; }
        public string Reference { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public string NameClient { get; set; }
        public string Codigo { get; set; }

        public Clients Client { get; set; }
        public Vendors Vendor { get; set; }
        public ICollection<BillDetails> BillDetails { get; set; }
        public ICollection<Receipts> Receipts { get; set; }
    }
}
