using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinicavalle.DbModels.Clinica;
using Microsoft.AspNetCore.Mvc;
using ReportsClinicaValle.Services;

namespace ReportsClinicaValle.Controllers
{
    public class ProvidersController : Controller
    {
        private ClinicaContext _db = null;
        public ProvidersController(ClinicaContext db)
        {
            this._db = db;
        }
        public IActionResult Compras()
        {
            var result = _db.vwCompras.Where(x => x.PaymentTypeId == 1).ToArray();

            var report = new Reports.Compras.xrCompras()
            {
                DataSource = result
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);
        }
    }
}