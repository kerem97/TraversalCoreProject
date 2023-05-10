using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf ");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfpTable = new PdfPTable(3);
            pdfpTable.AddCell("Misafir Adı");
            pdfpTable.AddCell("Misafir Soyadı");
            pdfpTable.AddCell("Misafir TC ");

            pdfpTable.AddCell("Kerem ");
            pdfpTable.AddCell("Durak ");
            pdfpTable.AddCell("11111111111");

            pdfpTable.AddCell("Osman ");
            pdfpTable.AddCell("Gül ");
            pdfpTable.AddCell("11111111241");

            pdfpTable.AddCell("Mehmet ");
            pdfpTable.AddCell("Kaya ");
            pdfpTable.AddCell("11145611111");
            document.Add(pdfpTable);

            document.Close();
            return File("/PdfReports/dosya2.pdf", "application/pdf", "dosya2.pdf ");
        }
    }
}
