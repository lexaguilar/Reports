using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinicavalle.DbModels.Clinica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportsClinicaValle.Services;
using ReportsClinicaValle.ViewModels;

namespace ReportsClinicaValle.Controllers
{
    public class ClientsController : Controller
    {
        private ClinicaContext _db = null;
        public ClientsController(ClinicaContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            var result = _db.Clients.Include(x =>x.City).Select(x => new ClientViewModel {
                Nombres = x.Name + " " + x.LastName,
                Direccion = x.Address,
                Ciudad = x.City == null ? "" : x.City.Name,
                Telefono = x.PhoneNumber
            }).ToArray();

            var report = new Reports.Clientes.xrClient
            {
                DataSource = result
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);
        }

        public IActionResult Receivables()
        {
            var result = _db.vwFacturasPendientes
                .Select(x => new ClientViewModel
                {
                    Nombres = x.Name + " " + x.LastName,
                    Direccion = x.Address,
                    Telefono = x.PhoneNumber,
                    Deuda = x.Deuda
                }).ToArray();



            var report = new Reports.Clientes.xrDeudas
            {
                DataSource = result
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);
        }

        public IActionResult PorEdad(int? from, int? to, DateTime? nace)
        {

            (int edad, bool result) EvalEdad(DateTime? nacimineto){
                var edad = CalculateEdad(nacimineto);

                var estaEnRango = edad >= from && edad <= to;

                return (edad, estaEnRango);

            }

            var result = _db.Clients
               .Select(x => new ClientViewModel
            {
                Nombres = x.Name + " " + x.LastName,
                Direccion = x.Address,
                Nacimiento = x.Birthdate,
                Telefono = x.PhoneNumber
            }).AsEnumerable();

            if (nace != null)
                result = result.Where(x => x.Nacimiento == nace).ToArray();

            if(from != null && to != null)
                result = result.Where(x => EvalEdad(x.Nacimiento).result).ToArray();

            var report = new Reports.Clientes.xrClientsAges
            {
                DataSource = result
            };

            var pdf = new PdfServices();

            return pdf.ExportPdf(report);
        }

        private int CalculateEdad(DateTime? birthDate)
        {
            if (birthDate == null) return 0;

            return ((int.Parse(DateTime.Now.ToString("yyyyMMdd")) - int.Parse(birthDate.Value.ToString("yyyyMMdd"))) / 10000);
        }

    }
}