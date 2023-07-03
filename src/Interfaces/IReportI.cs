using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IReportI
    {
        string Course_id { get; set; }
        string Course_name { get; set; }
        string Instructor_name { get; set; }
        int Number_of_students { get ; set; }
    }
}
