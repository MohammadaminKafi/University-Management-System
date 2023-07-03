using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface ICourse
    {
        string Id { get; set; }
        string Name { get; set; }
        string Field { get; set; }
        int Unit { get; set; }
        string Instructor_id { get; set; }
        //List<IStudent> Students { get; set; }
        //Dictionary<IStudent, double> grades { get; set; }
        string Semester_id { get; set; }
    }
}
