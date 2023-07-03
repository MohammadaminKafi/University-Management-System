using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface ISemester
    {
        string Id { get; set; }
        string Start_of_semester { get; set; }
        string End_of_semester { get;  set; }
        string Start_of_registration { get; set; }
        string End_of_registration { get; set; }
        //List<ICourse> Courses { get; set; }
    }
}
