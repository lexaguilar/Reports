﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;



namespace Clinicavalle.DbModels.Clinica
{
    public partial class SentMessage
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TemplateId { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
        public string SendBy { get; set; }

        public virtual Client Client { get; set; }
    }
}