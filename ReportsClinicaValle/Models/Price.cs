using System;
using System.Collections.Generic;



namespace Clinicavalle.DbModels.Clinica
{
    public partial class Price
    {
        public Price()
        {
            ItemPrices = new HashSet<ItemPrice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ItemPrice> ItemPrices { get; set; }
    }
}
