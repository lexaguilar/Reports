using System;
using System.IO;

namespace ReportDll
{
    public class Registers
    {
        public MemoryStream GeneratePDF()
        {
            var report = new Reports.Register();

            MemoryStream stream = new MemoryStream();
            report.CreateDocument();
            report.PrintingSystem.ExportToPdf(stream);
            stream.Position = 0;
            return stream;
        }
    }
}
