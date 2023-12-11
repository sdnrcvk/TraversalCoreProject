
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using Document = iTextSharp.text.Document;

namespace TraversalCoreProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport() 
        {
            Guid guid = Guid.NewGuid();
            var root = "wwwroot/pdfreports/";
            var fileName = "static" + guid.ToString() + ".pdf";

            string path = Path.Combine(Directory.GetCurrentDirectory(), root + fileName);

            //string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document,stream);

            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();

            //return File("/pdfreports/dosya1.pdf","application/pdf","dosya1.pdf");
            return File("/pdfreports/" + fileName, "application/pdf", fileName);
        }

        public IActionResult StaticCustomerReport()
        {
            Guid guid= Guid.NewGuid();
            var root = "wwwroot/pdfreports/";
            var fileName = "static" + guid.ToString() + ".pdf";

            string path = Path.Combine(Directory.GetCurrentDirectory(),root+fileName);
            
            //string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            // Use a font that supports Turkish characters
            BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            // Create a font with the specified BaseFont and size
            Font f = new Font(baseFont, 12);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);
            //pdfPTable.AddCell("Misafir Adı");
            //pdfPTable.AddCell("Misafir Soyadı");
            //pdfPTable.AddCell("Misafir TC");

            //pdfPTable.AddCell("Eylül");
            //pdfPTable.AddCell("Yücedağ");
            //pdfPTable.AddCell("11111111110");

            //pdfPTable.AddCell("Kemal");
            //pdfPTable.AddCell("Yıldırım");
            //pdfPTable.AddCell("22222222220");

            //pdfPTable.AddCell("Mehmet");
            //pdfPTable.AddCell("Yücedağ");
            //pdfPTable.AddCell("33333333330");

            pdfPTable.AddCell(new PdfPCell(new Phrase("Misafir Adı", f)));
            pdfPTable.AddCell(new PdfPCell(new Phrase("Misafir Soyadı", f)));
            pdfPTable.AddCell(new PdfPCell(new Phrase("Misafir TC", f)));

            pdfPTable.AddCell(new PdfPCell(new Phrase("Eylül", f)));
            pdfPTable.AddCell(new PdfPCell(new Phrase("Yücedağ", f)));
            pdfPTable.AddCell(new PdfPCell(new Phrase("11111111110", f)));

            pdfPTable.AddCell(new PdfPCell(new Phrase("Kemal", f)));
            pdfPTable.AddCell(new PdfPCell(new Phrase("Yıldırım", f)));
            pdfPTable.AddCell(new PdfPCell(new Phrase("22222222220", f)));

            pdfPTable.AddCell(new PdfPCell(new Phrase("Mehmet", f)));
            pdfPTable.AddCell(new PdfPCell(new Phrase("Yücedağ", f)));
            pdfPTable.AddCell(new PdfPCell(new Phrase("33333333330", f)));

            document.Add(pdfPTable);
            document.Close();

            //return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
            return File("/pdfreports/"+fileName, "application/pdf",fileName);

        }
    }
}
