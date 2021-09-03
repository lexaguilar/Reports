using System;
using System.Collections.Generic;

namespace ReportsSora.Models
{
    public partial class Families
    {
        public Families()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
