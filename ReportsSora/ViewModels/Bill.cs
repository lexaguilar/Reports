using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsSora.ViewModels
{
    public class Bill
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public string GrantTotal { get; set; }
        public string Name { get; set; }
        public string Direccion { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        //detalle
        public string ServiceName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }

    }    

    public class Receipts
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public string Total { get; set; }
        public string Balance { get; set; }
        public string Amount{ get; set; }

        public string Name { get; set; }
        public string Direccion { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
    }
}
