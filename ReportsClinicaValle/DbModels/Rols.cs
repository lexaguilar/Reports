using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Rols
    {
        public Rols()
        {
            RolResources = new HashSet<RolResources>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RolResources> RolResources { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
