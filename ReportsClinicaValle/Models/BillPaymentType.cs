﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;



namespace Clinicavalle.DbModels.Clinica
{
    public partial class BillPaymentType
    {
        public BillPaymentType()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}