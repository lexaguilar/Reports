﻿using System;
using System.Collections.Generic;

namespace ReportsClinicaValle.DbModels
{
    public partial class Apps
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slogan { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Website { get; set; }
        public int DefaultCurrency { get; set; }
        public int? Decimals { get; set; }
        public bool ValidatePriceGreaterCost { get; set; }
        public int AreaMainId { get; set; }
    }
}
