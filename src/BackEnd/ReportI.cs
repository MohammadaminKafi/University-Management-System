using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProjectUltimate.Interfaces;

namespace FinalProjectUltimate.BackEnd
{
    internal class ReportI : IReportI
    {
        private string course_id;
        private string course_name;
        private string instructor_name;
        private int number_of_students;

        public string Course_id { get => course_id; set => course_id = value; }
        public string Course_name { get => course_name; set => course_name = value; }
        public string Instructor_name { get => instructor_name; set => instructor_name = value; }
        public int Number_of_students { get => number_of_students; set => number_of_students = value; }

        public ReportI(string course_id, string course_name, string instructor_name, int number_of_students)
        {
            this.course_id = course_id;
            this.course_name = course_name;
            this.instructor_name = instructor_name;
            this.number_of_students = number_of_students;
        }
    }
}
