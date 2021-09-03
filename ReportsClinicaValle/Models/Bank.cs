using System;
using System.Collections.Generic;



namespace Clinicavalle.DbModels.Clinica
{
    public partial class Bank
    {
        public Bank()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
