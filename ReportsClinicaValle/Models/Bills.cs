using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.Models
{
    public partial class Bills
    {
        public Bills()
        {
            Receipts = new HashSet<Receipts>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PaymentTypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string Observation { get; set; }
        public bool Active { get; set; }
        public int CreditDays { get; set; }
        public bool Payoff { get; set; }
        public int? PaymentMethodId { get; set; }
        public int? BankId { get; set; }
        public string Reference { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }

        public Clients Client { get; set; }
        public ICollection<Receipts> Receipts { get; set; }
    }
}
