﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;



namespace Clinicavalle.DbModels.Clinica
{
    public partial class Rol
    {
        public Rol()
        {
            RolResources = new HashSet<RolResource>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RolResource> RolResources { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}