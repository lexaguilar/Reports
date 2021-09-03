using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class ServiceTests
    {
        public ServiceTests()
        {
            ServiceTestBaarDetails = new HashSet<ServiceTestBaarDetails>();
            ServiceTestCultives = new HashSet<ServiceTestCultives>();
            ServiceTestDetails = new HashSet<ServiceTestDetails>();
        }

        public int Id { get; set; }
        public int FollowId { get; set; }
        public int SendTestId { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public int DoctorId { get; set; }

        public Doctors Doctor { get; set; }
        public Follows Follow { get; set; }
        public SendTests SendTest { get; set; }
        public ICollection<ServiceTestBaarDetails> ServiceTestBaarDetails { get; set; }
        public ICollection<ServiceTestCultives> ServiceTestCultives { get; set; }
        public ICollection<ServiceTestDetails> ServiceTestDetails { get; set; }
    }
}
