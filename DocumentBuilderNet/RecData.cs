
/*
    Implements two support functions.  


    Copyright (C) 2023  Ainia Solutions Oy

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */


using iText.Kernel.Pdf;
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
