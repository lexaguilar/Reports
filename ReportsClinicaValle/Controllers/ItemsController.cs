using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinicavalle.DbModels.Clinica;
using Microsoft.AspNetCore.Mvc;
using ReportsClinicaValle.Services;

namespace ReportsClinicaValle.Controllers
{
    public class ItemsController : Controller
    {
        private ClinicaContext _db = null;
        public ItemsController(ClinicaContext db)
        {
            this._db = db;
        }
        public IActionResult ValorAlmacen()
        {
            var result = _db.vwValoracionAlmacen.ToArray();

            var report = new Reports.Items.xrValoracionAlmacen()
            {
                DataSource = result
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);
        }
    }
}