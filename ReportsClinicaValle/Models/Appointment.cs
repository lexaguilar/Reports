﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;



namespace Clinicavalle.DbModels.Clinica
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int DoctorId { get; set; }
        public int ActivityId { get; set; }
        public DateTime DateTime { get; set; }
        public string Note { get; set; }
        public bool Notify { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Client Client { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}