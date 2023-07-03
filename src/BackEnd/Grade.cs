using FinalProjectUltimate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.BackEnd
{
    internal class Grade : IGrade
    {
        private string semester_id;
        private string course_id;
        private string student_id;
        private float score;
        private int unit;

        public string Semester_id { get => semester_id; set => semester_id = value; }
        public string Course_id { get => course_id; set => course_id = value; }
        public string Student_id { get => student_id; set => student_id = value; }
        public float Score { get => score; set => score = value; }
        public int Unit { get => unit; set => unit = value; }

        public Grade(string semester_id, string course_id, string student_id, float score)
        {
            this.semester_id = semester_id;
            this.course_id = course_id;
            this.student_id = student_id;
            this.score = score;
        }

        public Grade(string semester_id, string course_id, string student_id, float score, int unit) : this(semester_id, course_id, student_id, score)
        {
            this.unit = unit;
        }
    }
}
