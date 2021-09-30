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
using ReportsClinicaValle.ViewModels;

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

        public IActionResult BySeasion(DateTime from, DateTime to, string username)
        {

            IQueryable<vwBills> result = _db.vwBills.Where(x => x.Date > from && x.Date < to);

            if (!string.IsNullOrEmpty(username))
                result = result.Where(x => x.CreateBy == username);

            var data = result.ToArray().Select(x => new BillsViewModels
            {
                Cliente = $"{x.Name} {x.LastName}",
                Fecha = x.Date,
                Referencia = x.Reference,
                Factura =  x.Id.ToString().PadLeft(6,'0'),
                SubTotal = x.SubTotal,
                Descuento = x.Discount,
                Total = x.Total
            }).ToArray();

            var report = new Reports.Bills.xrBillsBySeason()
            {
                DataSource = data
            };

            report.Parameters["search"].Value = $"Ventas realizadas entre el {from.ToString("dd-MM-yyyy")} y el {to.ToString("dd-MM-yyyy")}";
            report.Parameters["search"].Visible = false;

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }

        public IActionResult Items(DateTime from, DateTime to)
        {

            var result = _db.vwItems.Where(x => x.Date > from && x.Date < to).ToArray();

            var report = new Reports.Bills.xrItems()
            {
                DataSource = result
            };

            report.Parameters["search"].Value = $"Articulos vendidos entre el {from.ToString("dd-MM-yyyy")} y el {to.ToString("dd-MM-yyyy")}";
            report.Parameters["search"].Visible = false;

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }

        public IActionResult Inventario(int? typeId)
        {

            IQueryable<vwIntentario> result = _db.vwIntentario.Where(x => x.TypeId != 4); //servicios

            if (typeId.HasValue && typeId.Value > 0)
                result = result.Where(x => x.TypeId == typeId.Value);

            var data = result.Select(x => new InventarioViewModel {
                Id = x.Id,
                Nombre = x.Name,
                PCompra = x.Cost,
                IVA = 0,
                PVP = x.Price,
                Existencia = x.Stock,
                Code = x.Code
            }).ToArray();

            var report = new Reports.Bills.xrInventario()
            {
                DataSource = data
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }

        public IActionResult Proveedores()
        {

            var result = _db.Providers.ToArray();         

            var report = new Reports.Proveedores.xrProviders()
            {
                DataSource = result
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }
    }
}
