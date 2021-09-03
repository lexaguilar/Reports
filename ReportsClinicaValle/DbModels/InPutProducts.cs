using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class InPutProducts
    {
        public InPutProducts()
        {
            InPutProductDetails = new HashSet<InPutProductDetails>();
        }

        public int Id { get; set; }
        public int AreaId { get; set; }
        public int TypeId { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Import { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public decimal Rate { get; set; }
        public string Observation { get; set; }
        public int CurrencyId { get; set; }
        public int StateId { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public string Reference { get; set; }
        public int? ProviderId { get; set; }

        public Areas Area { get; set; }
        public Currencies Currency { get; set; }
        public Providers Provider { get; set; }
        public InPutProductStates State { get; set; }
        public InPutProductTypes Type { get; set; }
        public ICollection<InPutProductDetails> InPutProductDetails { get; set; }
    }
}
