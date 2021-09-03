using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Products
    {
        public Products()
        {
            AreaProductStocks = new HashSet<AreaProductStocks>();
            BillDetails = new HashSet<BillDetails>();
            InPutProductDetails = new HashSet<InPutProductDetails>();
            OutPutProductDetails = new HashSet<OutPutProductDetails>();
            PrivateWorkOrderDetails = new HashSet<PrivateWorkOrderDetails>();
            TraslateDetails = new HashSet<TraslateDetails>();
            WorkOrderDetails = new HashSet<WorkOrderDetails>();
            WorkPreOrderDetails = new HashSet<WorkPreOrderDetails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FamilyId { get; set; }
        public int PresentationId { get; set; }
        public int UnitOfMeasureId { get; set; }
        public bool HasIva { get; set; }
        public int StateId { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime LastDateModificationAt { get; set; }
        public string LastModificationBy { get; set; }
        public int CurrencyId { get; set; }
        public double? StockMin { get; set; }

        public Currencies Currency { get; set; }
        public Families Family { get; set; }
        public Presentations Presentation { get; set; }
        public ProductStates State { get; set; }
        public UnitOfMeasures UnitOfMeasure { get; set; }
        public ICollection<AreaProductStocks> AreaProductStocks { get; set; }
        public ICollection<BillDetails> BillDetails { get; set; }
        public ICollection<InPutProductDetails> InPutProductDetails { get; set; }
        public ICollection<OutPutProductDetails> OutPutProductDetails { get; set; }
        public ICollection<PrivateWorkOrderDetails> PrivateWorkOrderDetails { get; set; }
        public ICollection<TraslateDetails> TraslateDetails { get; set; }
        public ICollection<WorkOrderDetails> WorkOrderDetails { get; set; }
        public ICollection<WorkPreOrderDetails> WorkPreOrderDetails { get; set; }
    }
}
