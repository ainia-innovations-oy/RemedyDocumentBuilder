using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using iText.Layout;
using iText.Html2pdf;
using iText.StyledXmlParser.Css.Media;

namespace DocumentBuilderNet
{

    internal class RecData
    {

        public static string GetTemplate(string path)
        {
            var stream = new FileStream(path, FileMode.Open);
            string tmp = "";

            using (StreamReader reader = new StreamReader(stream))
            {
                tmp = reader.ReadToEnd();
            }

           
            return tmp;
        }

        public static void DeleteHtmlFile(string path)
        {
            File.Delete(path);
        }

        public static void CreatePDFFIle(string template, string dest)
        {
            Console.WriteLine(template);

            PdfWriter pw = new PdfWriter(dest);
            PdfDocument pdfDocument = new PdfDocument(pw);

            ConverterProperties converterProperties = new ConverterProperties();
            converterProperties.SetMediaDeviceDescription(new iText.StyledXmlParser.Css.Media.MediaDeviceDescription(MediaType.PRINT));
      
            HtmlConverter.ConvertToPdf(GetTemplate(template), pw, converterProperties);
        }

    }
}
