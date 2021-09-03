using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class InPutProductStates
    {
        public InPutProductStates()
        {
            InPutProducts = new HashSet<InPutProducts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<InPutProducts> InPutProducts { get; set; }
    }
}
