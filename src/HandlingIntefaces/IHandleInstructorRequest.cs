using FinalProjectUltimate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.HandlingIntefaces
{
    internal interface IHandleInstructorRequest
    {
        IInstructor InstructorGeneralInformation(string username);
        string InstructorChangeInformation(string username, string email);
        string UserChangePassword(string username, string new_password);
        List<ICourse> InstructorCoursesInSemester(string username, string semester_id);
        List<IGrade> InstructorCoursesByStudentList(string username, string course_id, string semester_id);
        string SetFinalScore(string instructor_id, string student_id, string course_id, string semester_id, double grade);
        List<ISemester> Semesters();
    }
}
