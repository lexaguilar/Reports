using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class BillTypes
    {
        public BillTypes()
        {
            Bills = new HashSet<Bills>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Bills> Bills { get; set; }
    }
}
