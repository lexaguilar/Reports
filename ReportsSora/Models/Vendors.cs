using System;
using System.Collections.Generic;

namespace ReportsSora.Models
{
    public partial class Vendors
    {
        public Vendors()
        {
            Bills = new HashSet<Bills>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string Observation { get; set; }
        public bool Active { get; set; }

        public ICollection<Bills> Bills { get; set; }
    }
}
