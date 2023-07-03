using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProjectUltimate.Interfaces;

namespace FinalProjectUltimate.BackEnd
{
    internal class ReportII : IReportII
    {
        private string field_id;
        private string field_name;
        private int number_of_students;
        private int number_of_courses;
        private int number_of_instructors;

        public string Field_id { get => field_id; set => field_id = value; }
        public string Field_name { get => field_name; set => field_name = value; }
        public int Number_of_students { get => number_of_students; set => number_of_students = value; }
        public int Number_of_courses { get => number_of_courses; set => number_of_courses = value; }
        public int Number_of_instructors { get => number_of_instructors; set => number_of_instructors = value; }

        public ReportII(string field_id, string field_name, int number_of_students, int number_of_courses, int number_of_instructors)
        {
            this.field_id = field_id;
            this.field_name = field_name;
            this.number_of_students = number_of_students;
            this.number_of_courses = number_of_courses;
            this.number_of_instructors = number_of_instructors;
        }
    }
}
