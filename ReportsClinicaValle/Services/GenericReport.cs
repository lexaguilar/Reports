using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsClinicaValle.Services
{
    public class PdfServices
    {
        public FileStreamResult ExportPdf(DevExpress.XtraReports.UI.XtraReport report)
        {
            MemoryStream stream = new MemoryStream();
            report.CreateDocument();
            report.PrintingSystem.ExportToPdf(stream);
            stream.Position = 0;
            var resultPDF = new FileStreamResult(stream, "application/pdf");
            return resultPDF;
        }
    }
}
