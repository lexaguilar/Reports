using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.Models
{
    public partial class Products
    {
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
        public DateTime ModifyAt { get; set; }
        public string ModifyBy { get; set; }
        public string BarCode { get; set; }
        public string InternalCode { get; set; }
    }
}
