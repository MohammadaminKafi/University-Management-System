using FinalProjectUltimate.BackEnd;
using FinalProjectUltimate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.HandlingIntefaces
{
    internal interface IHandleEmployeeRequest
    {
        string AddSemester(string id, string start, string end, string start_reg, string end_reg);
        string AddCourse(string course_id, string course_name, string instructor_id, int unit, string field, string semester_id);
        string DeleteCourse(string course_id);
        string UpdateCourse(string course_id, string course_name, string instructor_id, int unit, string field);
        List<IStudent> Students();
        List<IInstructor> Instructors();
        string UpdateStudent(string id, string first_name, string last_name, string field, string phone_number, string national_number);
        string DeleteStudent(string id);
        string UpdateInstructor(string id, string first_name, string last_name, string field, string email);
        string DeleteInstructor(string id);
        string AddStudentToCourse(string student_id, string course_id);
        string RemoveStudentFromCourse(string student_id, string course_id);
        string AddInstructorToCourse(string instructor_id, string course_id);
        string RemoveInstructorFromCourse(string instructor_id, string course_id);
        //List<ReportI> EmployeeReportI();
        //List<ReportII> EmployeeReportII();
    }
}
