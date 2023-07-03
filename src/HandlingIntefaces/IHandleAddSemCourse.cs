using FinalProjectUltimate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.HandlingIntefaces
{
    internal interface IHandleAddSemCourse
    {
        string AddCourse(string course_id, string course_name, string instructor_id, int unit, string field, string semester_id);
        string AddSemester(string id, string start, string end, string start_reg, string end_reg);
        string AddField(string id, string field);
        List<IInstructor> Instructors();
    }
}
