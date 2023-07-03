using FinalProjectUltimate.BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IDBDelete
    {
        void DeleteAllUsers();
        void DeleteUser(string username);
        void DeleteCourse(string course_id);
        void DeleteInstructor(string instructor_id);
        void DeleteStudent(string student_id);
        void DeleteStudentFromCourse(string student_id, string course_id, string semester_id);
    }
}
