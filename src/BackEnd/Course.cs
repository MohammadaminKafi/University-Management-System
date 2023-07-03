using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProjectUltimate.Interfaces;

namespace FinalProjectUltimate.BackEnd
{
    internal class Course : ICourse
    {
        // properties concering with object being a course
        private string id;
        private string name;
        private string field;
        private string instructor_id;
        private List<IStudent> students;
        private Dictionary<IStudent, double> grades;
        private string semester_id;
        private int unit;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Field { get => field; set => field = value; }
        public string Instructor_id { get => instructor_id; set => instructor_id = value; }
        public List<IStudent> Students { get => students; set => students = value; }
        public Dictionary<IStudent, double> Grades { get => grades; set => grades = value; }
        public string Semester_id { get => semester_id; set => semester_id = value; }
        public int Unit { get => unit; set => unit = value; }


        // other properties

        // default constructor
        public Course() { }

        // parameterized cunstructor
        public Course(string id, string semester_id, string instructor_id, int unit, string field, string name)
        {
            this.id= id;
            this.semester_id= semester_id;
            this.instructor_id= instructor_id;
            this.unit= unit;
            this.field= field;
            this.name= name;
        }

    }
}
