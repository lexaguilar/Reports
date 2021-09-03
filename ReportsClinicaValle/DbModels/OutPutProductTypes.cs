using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class OutPutProductTypes
    {
        public OutPutProductTypes()
        {
            OutPutProducts = new HashSet<OutPutProducts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<OutPutProducts> OutPutProducts { get; set; }
    }
}
