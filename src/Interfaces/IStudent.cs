using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IStudent
    {
        string Username { set;  get; }

        string Field { set; get; }
        string First_name { set; get; }
        string Last_name { set; get; }
        //List<ICourse> Courses { set; get; }
        string Email { get; set; }
        string Phone_number { get; set; }
        string National_number { get; set; }
        string Birth_date { get; set; }
        string City { get; set; }
        string Address { get; set; }
        double Overall_average { get; set; }
        int Total_passed_units { get; set; }

    }
}
