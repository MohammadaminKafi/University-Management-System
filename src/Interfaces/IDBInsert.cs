using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IDBInsert
    {
        void InsertUser(string username, string password, string role);
        void InsertStudent(string username, string first_name, string last_name, string email, string phone_num, string birth_date, string city, string address);
        void InsertInstructor(string username, string first_name, string last_name,string field, string email);
        void InsertEmployee(string username, string first_name, string last_name);
        void InsertSemester(string id, string start, string end, string start_reg, string end_reg);
        void InsertCourse(string course_id, string semester_id, string instructor_id, int unit, string field, string name);
        void InsertGrade(string semester_id, string course_id, string student_id);
        void InsertField(string field_id, string field_name);
    }
}
