using FinalProjectUltimate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Additionals
{
    internal interface IConvertToExcel
    {
        void ListToExcel(List<IExcelable> excelable_list, string resault_name);
    }
}
