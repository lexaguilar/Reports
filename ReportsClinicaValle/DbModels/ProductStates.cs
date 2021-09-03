using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class ProductStates
    {
        public ProductStates()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
