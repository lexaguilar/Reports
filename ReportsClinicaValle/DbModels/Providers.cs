using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Providers
    {
        public Providers()
        {
            InPutProducts = new HashSet<InPutProducts>();
        }

        public int Id { get; set; }
        public string Ruc { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Observation { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime? LastDateModificationAt { get; set; }
        public string LastModificationBy { get; set; }
        public int StateId { get; set; }

        public ProviderStates State { get; set; }
        public ICollection<InPutProducts> InPutProducts { get; set; }
    }
}
