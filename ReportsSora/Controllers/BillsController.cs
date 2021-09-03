using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReportsSora.Models;
using Microsoft.EntityFrameworkCore;
using ReportsSora.Services;

namespace ReportsSora.Controllers
{
    public class BillsController : Controller
    {
        private SoraContext _db = null;
        public BillsController(SoraContext db)
        {
            this._db = db;
        }

        public IActionResult Index(int id)
        {
            var format = "F";

            var data = (from b in _db.Bills
                        join bd in _db.BillDetails on b.Id equals bd.BillId
                        join p in _db.Products on bd.ProductId equals p.Id
                        join c in _db.Clients on b.ClientId equals c.Id
                        where b.Id == id
                        select new ViewModels.Bill {
                            Id = b.Id,
                            Name = $"{(string.IsNullOrEmpty(b.NameClient) ? $"{c.Name} {c.LastName}" : b.NameClient)}",
                            Direccion = c.Address,
                            CreateAt = b.CreateAt,
                            CreateBy = b.CreateBy,
                            GrantTotal = $"C$ {b.Total.ToString(format)}",
                            Referencia = b.Reference,
                            Price = bd.CustomPrice,
                            Quantity = Convert.ToDecimal(bd.Quantity),
                            Total = bd.Total,
                            ServiceName = bd.Product.Name
                        }).ToArray();         

            var report = new Reports.Bill()
            {
                DataSource = data
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }

        private decimal Calculate(decimal price, decimal customPrice, decimal cantidad, decimal percent, decimal rate)
        {
            if (price == customPrice)
            {             
                return 1 * rate;
            }
            else
            {
                return Convert.ToDecimal((customPrice - price) * cantidad * percent / 100);
            }

        }

        public IActionResult Commission(DateTime desde, DateTime hasta)
        {
            var app = _db.Apps.FirstOrDefault();

            var rates = _db.Rates.FirstOrDefault(x => x.Date == DateTime.Today);
            var rate = 0M;
            if (rates != null)
                rate = rates.Value;

            var result =  (from b in _db.Bills
             join bd in _db.BillDetails on b.Id equals bd.BillId
             join p in _db.Products on bd.ProductId equals p.Id
             join c in _db.Clients on b.ClientId equals c.Id
             join v in _db.Vendors on b.VendorId equals v.Id
             where b.Date >= desde && b.Date <= hasta
             select new ViewModels.VendorsCommissoins
             {
                 FacturaId = b.Id.ToString(),
                 Vendor = v.FullName,
                 Date = b.Date,                
                Producto = p.Name,
                Cantidad = bd.Quantity,
                Descripcion = bd.Product.Description,
                Precio = bd.CustomPrice,
                Total = bd.Total,
                Comision = Calculate(bd.Price, bd.CustomPrice, Convert.ToDecimal(bd.Quantity), app.CommissionPercent, rate)
             }).ToArray();

            var report = new Reports.xrCommission()
            {
                DataSource = result
            };

            report.Parameters["desde"].Value = desde;
            report.Parameters["desde"].Visible = false;
            report.Parameters["hasta"].Value = hasta;
            report.Parameters["hasta"].Visible = false;

            var reportView = _db.Reports.FirstOrDefault(x => x.Name == nameof(Reports.xrCommission));           
            if (reportView != null && reportView.Preview)
                return View(report);

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }

        public IActionResult Products(DateTime desde, DateTime hasta, string username)
        {
            
            var data = (from b in _db.Bills
                    join bd in _db.BillDetails on b.Id equals bd.BillId
                    join p in _db.Products on bd.ProductId equals p.Id
                    join f in _db.Families on p.FamilyId equals f.Id
                    join pre in _db.Presentations on p.PresentationId equals pre.Id
                    where b.Date >= desde && b.Date <= hasta
                    select new ViewModels.ProductsInfo
                    {
                        Nombre = p.Name,
                        Descripcion = $"{p.Description}/{f.Name}/{pre.Name}" ,
                        Cantidad = bd.Quantity,
                        Precio = bd.CustomPrice,
                        Total = bd.Total,
                        Marca = f.Name,
                        Modelo = pre.Name,
                        Factura = $"#{b.Id}"
                    }).ToArray();

            var report = new Reports.xrProductInfo()
            {
                DataSource = data
            };

            report.Parameters["desde"].Value = desde;
            report.Parameters["desde"].Visible = false;
            report.Parameters["hasta"].Value = hasta;
            report.Parameters["hasta"].Visible = false;
            report.Parameters["username"].Value = $"Impreso por : {username}" ;
            report.Parameters["username"].Visible = false;

            var reportView = _db.Reports.FirstOrDefault(x => x.Name == nameof(Reports.xrProductInfo));
            if (reportView != null && reportView.Preview)
                return View(report);

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }
    }

    public class CommisionRequest
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
    }
}
