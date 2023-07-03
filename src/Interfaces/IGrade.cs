using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IGrade
    {
        string Semester_id { get; set; }
        string Course_id { get; set; }
        string Student_id { get; set; }
        float Score { get; set; }
        int Unit { get; set; }
    }
}
