using FinalProjectUltimate.BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProjectUltimate.Interfaces;

namespace FinalProjectUltimate.HandlingIntefaces
{
    internal interface IHandleStudentRequest
    {
        IStudent StudentGeneralInformation(string username);
        string StudentChangeInformation(string username, string email, string phone_number, string birth_date, string city, string address);
        string StudentRegistration(string username, string course_id, string semester_id, string previous_semester_id);
        string UserChangePassword(string username, string new_password);
        List<IGrade> StudentGrades(string username, string semester_id);
        List<ICourse> courses(string semester);
        string LatestSemester();
        string OneToLatestSemester();
    }
}
