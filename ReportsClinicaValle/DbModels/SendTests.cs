using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class SendTests
    {
        public SendTests()
        {
            SendTestDetails = new HashSet<SendTestDetails>();
            ServiceTests = new HashSet<ServiceTests>();
        }

        public int Id { get; set; }
        public int FollowId { get; set; }
        public DateTime Date { get; set; }
        public int DoctorId { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }

        public Doctors Doctor { get; set; }
        public Follows Follow { get; set; }
        public ICollection<SendTestDetails> SendTestDetails { get; set; }
        public ICollection<ServiceTests> ServiceTests { get; set; }
    }
}
