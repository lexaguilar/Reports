using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Cie10
    {
        public Cie10()
        {
            Admissions = new HashSet<Admissions>();
            Subsidies = new HashSet<Subsidies>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<Admissions> Admissions { get; set; }
        public ICollection<Subsidies> Subsidies { get; set; }
    }
}
