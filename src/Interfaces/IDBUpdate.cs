using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IDBUpdate
    {
        void UpdatePassword(string username, string password);

        void UpdateStudentEmail(string username, string email);
        void UpdateStudentPhoneNumber(string username, string phone_number);
        void UpdateStudentBirthDate(string username, string date);
        void UpdateStudentCity(string username, string city);
        void UpdateStudentAddress(string username, string address);

        void UpdateInstructorEmail(string username, string email);
        void UpdateGrade(string semester_id, string course_id, string student_id, double grade);

        void UpdateCourseName(string id, string name);
        void UpdateCourseInstructor(string id, string instructor_id);
        void UpdateCourseUnit(string id, int unit);
        void UpdateCourseField(string id, string field);

        void UpdateInstructorField(string id, string field);

        void UpdateStudentField(string id, string field);
    }
}
