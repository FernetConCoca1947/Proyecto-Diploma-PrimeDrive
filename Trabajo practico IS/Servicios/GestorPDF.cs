using PdfSharp;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;



namespace Servicios
{
    public static class GestorPDF
    {
        public static void GenerarPdfDesdeHtml(string contenidoHtml, string rutaArchivoDestino)
        {
            var documentoPdf = PdfGenerator.GeneratePdf(contenidoHtml, PageSize.A4);
            documentoPdf.Save(rutaArchivoDestino);
        }
    }
}
