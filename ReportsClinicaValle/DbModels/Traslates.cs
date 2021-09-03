using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Traslates
    {
        public Traslates()
        {
            TraslateDetails = new HashSet<TraslateDetails>();
        }

        public int Id { get; set; }
        public int AreaSourceId { get; set; }
        public int AreaTargetId { get; set; }
        public DateTime Date { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Import { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public decimal Rate { get; set; }
        public string Observation { get; set; }
        public int CurrencyId { get; set; }
        public int StageId { get; set; }
        public int StateId { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime? LastDateModificationAt { get; set; }
        public string LastModificationBy { get; set; }

        public Areas AreaSource { get; set; }
        public Areas AreaTarget { get; set; }
        public Currencies Currency { get; set; }
        public TraslateStages Stage { get; set; }
        public ICollection<TraslateDetails> TraslateDetails { get; set; }
    }
}
