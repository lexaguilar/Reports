using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReportsClinicaValle.Models;
using Microsoft.EntityFrameworkCore;
using Clinicavalle.DbModels.Clinica;
using ReportsClinicaValle.Services;

namespace ReportsClinicaValle.Controllers
{
    public class ReceivablesController : Controller
    {
        private ClinicaContext _db = null;
        public ReceivablesController(ClinicaContext db)
        {
            this._db = db;
        }

        public IActionResult Index(int id)
        {
            var format = "F";
           

            var receipt = _db.Receipts.FirstOrDefault(x => x.Id == id);

            var bill = _db.Bills
               .Include(x => x.Client)
               .Include(x => x.Receipts)
               .Select(x => new 
               {
                   Id = x.Id,
                   Name = $"{x.Client.Name} {x.Client.LastName}",
                   Direccion = x.Client.Address,                 
                   GrantTotal = $"$ {x.Total.ToString(format)}",
                   x.Total,
                   x.Receipts
               })
               .FirstOrDefault(x => x.Id == receipt.BillId);

            var result = new List<ViewModels.Receipts>();

            result.Add(new ViewModels.Receipts
            {
                Id = receipt.Id,
                BillId = bill.Id,
                Name = bill.Name,
                Direccion=bill.Direccion,
                CreateAt = receipt.CreateAt,
                CreateBy = receipt.CreateBy,
                Total = $"$ {bill.Total - bill.Receipts.Where(x => x.Active).Sum(x => x.Amount) + receipt.Amount}",
                Amount =$"$ {receipt.Amount}",
                Balance = $"$ {bill.Total - bill.Receipts.Where(x => x.Active).Sum(x => x.Amount) }"
            });

            var report = new Reports.Receipt()
            {
                DataSource = result
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }

    }
}
