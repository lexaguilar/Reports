using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class TraslateStages
    {
        public TraslateStages()
        {
            Traslates = new HashSet<Traslates>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Traslates> Traslates { get; set; }
    }
}
