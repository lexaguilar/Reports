using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Rates
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}
