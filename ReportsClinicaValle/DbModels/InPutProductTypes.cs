using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class InPutProductTypes
    {
        public InPutProductTypes()
        {
            InPutProducts = new HashSet<InPutProducts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<InPutProducts> InPutProducts { get; set; }
    }
}
