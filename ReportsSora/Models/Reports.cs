using System;
using System.Collections.Generic;

namespace ReportsSora.Models
{
    public partial class Reports
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Preview { get; set; }
    }
}
