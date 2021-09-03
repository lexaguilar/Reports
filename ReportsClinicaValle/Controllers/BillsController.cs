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
    public class BillsController : Controller
    {
        private ClinicaContext _db = null;
        public BillsController(ClinicaContext db)
        {
            this._db = db;
        }

        public IActionResult Index(int id)
        {
            var format = "F";
            var result = _db.Bills                
                .Include(x => x.Client)
                .Include(x => x.BillDetails)
                .ThenInclude(x => x.Item)
                .Select(x => new ViewModels.Bill
                {
                    Id = x.Id,
                    Name = $"{x.Client.Name} {x.Client.LastName}",
                    Direccion = x.Client.Address,
                    CreateAt = x.CreateAt,
                    CreateBy = x.CreateBy,
                    GrantTotal = $"$ {x.Total.ToString(format)}",
                    billDetails = x.BillDetails.Select(d => new ViewModels.BillDetails
                    {
                        Price = d.Price,
                        Quantity = Convert.ToDecimal(d.Quantity),
                        Total = d.Total,
                        ServiceName = d.Item.Name
                    })
                })
                .Where(x => x.Id == id).ToArray();

            var report = new Reports.Bill()
            {
                DataSource = result
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }

    }
}
