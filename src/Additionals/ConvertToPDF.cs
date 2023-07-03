using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using ArrayToPdf;
using FinalProjectUltimate.Interfaces;

namespace FinalProjectUltimate.Additionals
{
    internal class ConvertToPDF : IConvertToPDF
    {
        public ConvertToPDF() { }

        public void ListToPdf(List<IPDFable> pdfable_list, string resault_name)
        {
            byte[] pdf = pdfable_list.ToPdf();
            string destination = @".\" + resault_name + ".pdf";
            File.WriteAllBytes(destination, pdf);
        }
    }
}
