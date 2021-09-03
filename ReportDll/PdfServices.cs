using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReportDll
{
    public class PdfServices
    {
        public MemoryStream ExportPdf(DevExpress.XtraReports.UI.XtraReport report)
        {
            MemoryStream stream = new MemoryStream();
            report.CreateDocument();
            report.PrintingSystem.ExportToPdf(stream);
            stream.Position = 0;
            return stream;

            //var resultPDF = new FileStreamResult(stream, "application/pdf");
            //return resultPDF;
        }
    }
}
