using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IDBSearch
    {
        bool DoesUserExists(string username);
        string PasswordByUsername(string username);
        string RoleByUsername(string username);
        IStudent SearchStudent(string username);
        List<IGrade> GradesOfStudentBySemester(string username, string semester_id);
        List<ISemester> Semesters();
        List<ICourse> CoursesOfStudentBySemester(string username, string semester_id);
        ICourse CourseById(string course_id);
        List<ICourse> AllPassesCourses(string username); 
        List<ICourse> CoursesBySemester(string semester_id);
        IInstructor InstructorById(string id);
        List<IInstructor> Instructors();
        List<IField> Fields();
        List<ICourse> InstructorCoursesBySemester(string instructor_id, string semester_id);
        List<IGrade> InstructorCourseByCourseId(string instructor_id, string course_id, string semester_id);
        List<IStudent> Students();
        List<ICourse> Courses();
        List<IStudent> StudentsInCourse(string course_id, string semester_id);
        //List<IStudent> StudentsWithField(string field_name);
        //List<ICourse> CoursesWithField(string field_name);
        //List<IInstructor> InstructorsWithField(string field_name);
    }
}
