﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Clinicavalle.DbModels.Clinica
{
    public partial class Activity
    {
        public Activity()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}