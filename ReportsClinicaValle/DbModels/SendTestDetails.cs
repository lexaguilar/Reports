using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class SendTestDetails
    {
        public int Id { get; set; }
        public int SendTestId { get; set; }
        public int Serviceid { get; set; }

        public SendTests SendTest { get; set; }
    }
}
