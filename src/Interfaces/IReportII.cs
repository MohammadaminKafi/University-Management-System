using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IReportII
    {
        string Field_id { get; set; }
        string Field_name { get; set; }
        int Number_of_students { get; set ; }
        int Number_of_courses { get; set ; }
        int Number_of_instructors { get; set ; }
    }
}
