using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using FinalProjectUltimate.Interfaces;

namespace FinalProjectUltimate.BackEnd
{
    internal class ActionStudent : IActionStudent
    {
        private IStudent student;

        public ActionStudent(IStudent student)
        {
            this.student = student;
        }

        public double CalculateAverage(string semester_id)
        {
            IDBSearch dB= new SQLiteManager();
            List<IGrade> grades = dB.GradesOfStudentBySemester(student.Username, semester_id);

            double count = 0;
            double total = 0;
            double average = 0;

            foreach (var item in grades)
            {
                count++;
                total += item.Score;
            }
            if (count == 0)
            {
                return 17;
            }
            average = total / count;
            return average;
        }
        public void ClaculateOverallAverage() 
        {

            double count = 0;
            double total = 0;
            double average = 0;

            IDBSearch dB = new SQLiteManager();
            List<ISemester> semesters = dB.Semesters();

            foreach (var semester in semesters)
            {
                List<IGrade> grades = dB.GradesOfStudentBySemester(student.Username, semester.Id);

                foreach (var grade in grades)
                {
                    count++;
                    total += grade.Score;
                }
            }
            if (count == 0)
            {
                return;
            }
            average = total / count;
            student.Overall_average= average;
        }
        public int CalculateUnits(string semester_id)
        {
            IDBSearch dB = new SQLiteManager();
            List<ICourse> courses = dB.CoursesOfStudentBySemester(student.Username ,semester_id);

            int total = 0;

            foreach (var course in courses)
            {
                total += course.Unit;
            }

            return total;
        }
        public int CalculateTotalPassedUnits()
        {
            IDBSearch dB = new SQLiteManager();
            List<ICourse> courses = dB.AllPassesCourses(student.Username);

            int total = 0;

            foreach (var course in courses)
            {
                total += course.Unit;
            }

            student.Total_passed_units = total;
            return total;
        }

    }
}
