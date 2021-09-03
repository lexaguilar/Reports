using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Users
    {
        public Users()
        {
            Admissions = new HashSet<Admissions>();
            Appointments = new HashSet<Appointments>();
        }

        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }
        public int AreaId { get; set; }
        public bool Active { get; set; }

        public Areas Area { get; set; }
        public Rols Rol { get; set; }
        public ICollection<Admissions> Admissions { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
    }
}
