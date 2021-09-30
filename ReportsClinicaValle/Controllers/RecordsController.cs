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
    public class RecordsController : Controller
    {
        private ClinicaContext _db = null;
        public RecordsController(ClinicaContext db)
        {
            this._db = db;
        }

        public IActionResult Index(int id)
        {
            var result = (from r in _db.Records
                         join refra in _db.Refractions on r.Id equals refra.RecordId
                         join p in _db.Prisms on new {r.Id , refra.Eye} 
                         equals new { Id = p.RecordId, p.Eye }
                         where r.Id == id
                         select new ViewModels.RecordCard
                         {
                             Date = r.Date,
                             Eye = refra.Eye,
                             Sphere = refra.Sphere,
                             Cylinder = refra.Cylinder,
                             Axis = refra.Axis,
                             Addition = refra.Addition
                             ,Axis2 = p.Axis,
                             Base =p.Base,
                             PrismId = p.PrismId
                         }).ToArray();

            var report = new Reports.RecordCard()
            {
                DataSource = result
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }

        public IActionResult List(DateTime from, DateTime to)
        {
            var result = _db.vwRecords.Where(x => x.Date > from && x.Date < to).Select(x => new RecordsViewModel {
                Nombre = $"{x.Name} {x.LastName}",
                Fecha = x.Date,
                Eje = $"{x.Axis}º" ,
                Cilindro = x.Cylinder,
                Esfera = x.Sphere,
                AV = x.AVSC,
                Addition = x.Addition,
                OJO = x.Eye
            }).ToArray();

            var report = new Reports.Records.xrRecords()
            {
                DataSource = result
            };            
                
            report.Parameters["search"].Value = $"Resultado entre el {from.ToString("dd-MM-yyyy")} y el {to.ToString("dd-MM-yyyy")}";
            report.Parameters["search"].Visible = false;                

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);

        }

    }
}
