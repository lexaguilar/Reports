﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;



namespace Clinicavalle.DbModels.Clinica
{
    public partial class RefractionsCycloplegic
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public string Eye { get; set; }
        public string Sphere { get; set; }
        public string Cylinder { get; set; }
        public string Axis { get; set; }
        public string Av { get; set; }

        public virtual Record Record { get; set; }
    }
}