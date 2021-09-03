using System;
using System.Collections.Generic;



namespace Clinicavalle.DbModels.Clinica
{
    public partial class Nlog
    {
        public int Id { get; set; }
        public string MachineName { get; set; }
        public DateTime Logged { get; set; }
        public string Level { get; set; }
        public string TraceId { get; set; }
        public string RequestHost { get; set; }
        public string RequestIp { get; set; }
        public string RequestUrl { get; set; }
        public string Message { get; set; }
        public string Logger { get; set; }
        public string Callsite { get; set; }
        public string Exception { get; set; }
        public string UserAgent { get; set; }
    }
}
