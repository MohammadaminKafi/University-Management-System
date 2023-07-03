using FinalProjectUltimate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.BackEnd
{
    // other types of semester may exist such as summer semester
    internal class Semester : ISemester
    {
        // id is constructed as year_number; For instance 2023_1 stands for first semester in year 2023
        // semesters are vital for organizing data in this project
        // data of courses and taken courses of each student or instructor is stored in a database named same as related semester

        // properties concerning with object being a semester
        private string id;
        private string start_of_semester;
        private string end_of_semester;
        private string start_of_registration;
        private string end_of_registration;
        //private List<ICourse> courses;

        public string Id { get => id; set => id = value; }
        public string Start_of_semester { get => start_of_semester; set => start_of_semester = value; }
        public string End_of_semester { get => end_of_semester; set => end_of_semester = value; }
        public string Start_of_registration { get => start_of_registration; set => start_of_registration = value; }
        public string End_of_registration { get => end_of_registration; set => end_of_registration = value; }

        public Semester(string id, string start_of_semester, string end_of_semester, string start_of_registration, string end_of_registration)
        {
            this.id = id;
            this.start_of_semester = start_of_semester;
            this.end_of_semester = end_of_semester;
            this.start_of_registration = start_of_registration;
            this.end_of_registration = end_of_registration;
        }
        //public List<ICourse> Courses { get => courses; set => courses = value; }



    }
}
