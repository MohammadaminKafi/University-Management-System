using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IInstructor
    {
        string Username { set; get; }

        string First_name { set; get; }
        string Last_name { set; get; }
        string Field { set; get; }
        //List<ICourse> Courses { set; get; }
        string Email { set; get; }
    }
}
