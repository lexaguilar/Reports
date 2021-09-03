using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Currencies
    {
        public Currencies()
        {
            Bills = new HashSet<Bills>();
            InPutProducts = new HashSet<InPutProducts>();
            OutPutProducts = new HashSet<OutPutProducts>();
            Products = new HashSet<Products>();
            Services = new HashSet<Services>();
            Traslates = new HashSet<Traslates>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public ICollection<Bills> Bills { get; set; }
        public ICollection<InPutProducts> InPutProducts { get; set; }
        public ICollection<OutPutProducts> OutPutProducts { get; set; }
        public ICollection<Products> Products { get; set; }
        public ICollection<Services> Services { get; set; }
        public ICollection<Traslates> Traslates { get; set; }
    }
}
