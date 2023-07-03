using FinalProjectUltimate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using ArrayToExcel;
using ArrayToPdf;

namespace FinalProjectUltimate.Additionals
{
    internal class ConvertToExcel : IConvertToExcel
    {
        public ConvertToExcel() { }

        public void ListToExcel(List<IExcelable> excelable_list, string resault_name)
        {
            byte[] excel = excelable_list.ToExcel();
            string destination = @".\" + resault_name + ".xlsx";
            File.WriteAllBytes(destination, excel);
        }
    }
}
