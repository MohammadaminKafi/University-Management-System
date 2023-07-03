using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

using FinalProjectUltimate.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using PdfSharp.Pdf.Content.Objects;

namespace FinalProjectUltimate.BackEnd
{
    internal class SQLiteManager : IDatabase
    {
        /*
         * -DB Golestan:
         *  -tables:
         *      -users
         *      -students
         *      -instructors
         *      -employees
         *      -semesters
         *      -courses
         *      -grades (for each semester)
         */

        // Default constructors
        public SQLiteManager() { }


        private string database_source = @"URI=file:.\Golestan.db3";


        /***************** CREATE *****************/
        // basic queries for creating base tables
        private string query_create_users_if_not_exists = @"CREATE TABLE IF NOT EXISTS users (
  username TEXT NOT NULL,
  password TEXT,
  role TEXT,
  PRIMARY KEY (username)
);";
        private string query_create_students_if_not_exists = @"CREATE TABLE IF NOT EXISTS students (
  id text NOT NULL,
  first_name TEXT,
  last_name TEXT,
  field TEXT,
  email TEXT,
  phone_num text,
  national_num text,
  birth_date text,
  city TEXT,
  address TEXT,
  PRIMARY KEY (id),
  FOREIGN KEY (id) REFERENCES users (username) ON DELETE NO ACTION ON UPDATE RESTRICT
);";
        private string query_create_instructors_if_not_exists = @"CREATE TABLE IF NOT EXISTS instructors (
  id text NOT NULL,
  first_name TEXT,
  last_name TEXT,
  field TEXT,
  email TEXT,
  PRIMARY KEY (id),
  FOREIGN KEY (id) REFERENCES users (username) ON DELETE NO ACTION ON UPDATE RESTRICT
);";
        private string query_create_employees_if_not_exists = @"CREATE TABLE IF NOT EXISTS employee (
  id text NOT NULL,
  first_name TEXT,
  last_name TEXT,
  PRIMARY KEY (id),
  FOREIGN KEY (id) REFERENCES users (username) ON DELETE NO ACTION ON UPDATE RESTRICT
);";
        private string query_create_semesters_if_not_exists = @"CREATE TABLE IF NOT EXISTS semesters (
  id text NOT NULL,
  start TEXT,
  end TEXT,
  start_registration TEXT,
  end_registration TEXT,
  PRIMARY KEY (id)
);";
        private string query_create_courses_if_not_exists = @"CREATE TABLE IF NOT EXISTS courses (
  id text NOT NULL,
  semester TEXT,
  instructor TEXT,
  unit INTEGER,
  field TEXT,
  name TEXT,
  PRIMARY KEY (id),
  FOREIGN KEY (semester) REFERENCES semesters (id) ON DELETE NO ACTION ON UPDATE RESTRICT,
  FOREIGN KEY (instructor) REFERENCES instructors (id) ON DELETE NO ACTION ON UPDATE RESTRICT
);";
        private string query_create_fields_if_not_exists = @"CREATE TABLE IF NOT EXISTS fields (
  id text NOT NULL,
  field TEXT,
  PRIMARY KEY (id),
);";

        // method for creating all basic tables if not exists
        public void CreateTablesIfNotExists()
        {
            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query_create_users_if_not_exists;
            cmd.ExecuteNonQuery();

            cmd.CommandText = query_create_students_if_not_exists;
            cmd.ExecuteNonQuery();

            cmd.CommandText = query_create_instructors_if_not_exists;
            cmd.ExecuteNonQuery();

            cmd.CommandText = query_create_employees_if_not_exists;
            cmd.ExecuteNonQuery();

            cmd.CommandText = query_create_semesters_if_not_exists;
            cmd.ExecuteNonQuery();

            cmd.CommandText = query_create_courses_if_not_exists;
            cmd.ExecuteNonQuery();

            cmd.CommandText = query_create_fields_if_not_exists;
            cmd.ExecuteNonQuery();

            con.Close();
        }

        // method for creating grades table for a semester if not exists
        public void CreateGradesForSemester(string semester_id)
        {
            string table_name = "grades_" + semester_id;
            string query_create_grades = $"CREATE TABLE IF NOT EXISTS {table_name} (id text NOT NULL, course TEXT, student TEXT, grade text, status TEXT, PRIMARY KEY (id), FOREIGN KEY (course) REFERENCES courses (id) ON DELETE NO ACTION ON UPDATE RESTRICT, FOREIGN KEY (student) REFERENCES students (id) ON DELETE NO ACTION ON UPDATE RESTRICT);";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query_create_grades;
            cmd.ExecuteNonQuery();

            con.Close();
        }


        /***************** INSERT *****************/
        public void InsertUser(string username, string password, string role) 
        { 
            string query = $"INSERT INTO users(username, password, role) VALUES('{username}', '{password}', '{role}')";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void InsertStudent(string username, string first_name, string last_name, string email, string phone_num, string birth_date, string city, string address)
        {
            string query = $"INSERT INTO students(id, first_name, last_name, email, phone_num, birth_date, city, address) VALUES('{username}', '{first_name}', '{last_name}', '{email}', '{phone_num}', '{birth_date}', '{city}', '{address}')";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void InsertInstructor(string username, string first_name, string last_name,string field, string email)
        {
            string query = $"INSERT INTO instructors(id, first_name, last_name, field, email) VALUES('{username}', '{first_name}', '{last_name}', '{field}', '{email}')";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void InsertEmployee(string username, string first_name, string last_name)
        {
            string query = $"INSERT INTO employees(id, first_name, last_name) VALUES('{username}', '{first_name}', '{last_name}')";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void InsertSemester(string id, string start, string end, string start_reg, string end_reg)
        {
            string query = $"INSERT INTO semesters(id, start, end, start_registration, end_registration) VALUES('{id}', '{start}', '{end}', '{start_reg}', '{end_reg}')";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void InsertCourse(string course_id, string semester_id, string instructor_id, int unit, string field, string name)
        {
            string query = $"INSERT INTO courses(id, semester, instructor, unit, field, name) VALUES('{course_id}', '{semester_id}', '{instructor_id}', {unit}, '{field}', '{name}')";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void InsertGrade(string semester_id, string course_id, string student_id)
        {
            string table_name = "grades_" + semester_id;
            string query = $"INSERT INTO {table_name} (course, student) VALUES('{course_id}', '{student_id}')";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void InsertField(string field_id, string field_name)
        {
            string query = $"INSERT INTO fields(id, field) VALUES('{field_id}', '{field_name}')";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }


        /***************** UPDATE *****************/
        public void UpdatePassword(string username, string password)
        {
            string query = $"UPDATE users SET password = '{password}' WHERE username = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateStudentEmail(string username, string email)
        {
            string query = $"UPDATE students SET email = '{email}' WHERE id = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateStudentPhoneNumber(string username, string phone_number)
        {
            string query = $"UPDATE students SET phone_num = '{phone_number}' WHERE id = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateStudentBirthDate(string username, string date)
        {
            string query = $"UPDATE students SET birth_date = '{date}' WHERE id = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateStudentCity(string username, string city)
        {
            string query = $"UPDATE students SET city = '{city}' WHERE id = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateStudentAddress(string username, string address)
        {
            string query = $"UPDATE students SET address = '{address}' WHERE id = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateInstructorEmail(string username, string email)
        {
            string query = $"UPDATE instructors SET email = '{email}' WHERE id = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateGrade(string semester_id, string course_id, string student_id, double grade)
        {
            string table_name = "grades_" + semester_id;
            string query = $"UPDATE {table_name} SET grade = {grade} WHERE student = '{student_id}' AND course = '{course_id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateCourseName(string id, string name)
        {
            string query = $"UPDATE courses SET name = '{name}' WHERE id = '{id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateCourseInstructor(string id, string instructor_id)
        {
            string query = $"UPDATE courses SET instructor = '{instructor_id}' WHERE id = '{id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateCourseUnit(string id, int unit)
        {
            string query = $"UPDATE courses SET unit = {unit} WHERE id = '{id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateCourseField(string id, string field)
        {
            string query = $"UPDATE courses SET field = '{field}' WHERE id = '{id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateInstructorField(string id, string field)
        {
            string query = $"UPDATE instructors SET field = '{field}' WHERE id = '{id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void UpdateStudentField(string id, string field)
        {
            string query = $"UPDATE students SET field = '{field}' WHERE id = '{id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }


        /***************** SEARCH *****************/
        public bool DoesUserExists(string username)
        {
            string query = $"SELECT username FROM users WHERE username = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<string> list = new List<string>();

            while (rdr.Read())
            {
                list.Add(rdr.GetString(0));
            }

            con.Close();

            if (list.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string PasswordByUsername(string username)
        {
            string query = $"SELECT password FROM users WHERE username = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            string password = "";

            while (rdr.Read())
            {
                password= rdr.GetString(0);
            }

            con.Close();

            return password;
        }
        public string RoleByUsername(string username)
        {
            string query = $"SELECT role FROM users WHERE username = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            string role = "None";

            while (rdr.Read())
            {
                role = rdr.GetString(0);
            }

            con.Close();

            return role;
        }
        public IStudent SearchStudent(string username)
        {
            string query = $"SELECT * FROM students WHERE id = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();
            
            IStudent student= new Student();

            while (rdr.Read())
            {
                student = new Student(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5),
                rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), rdr.GetString(9));
            }

            con.Close();

            return student;
        }
        public List<IGrade> GradesOfStudentBySemester(string student_id, string semester_id)
        {
            string table_name = "grades_" + semester_id;
            string query = $"SELECT * FROM {table_name} WHERE student = '{student_id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<IGrade> grades = new List<IGrade>();

            while (rdr.Read())
            {
                IGrade grade = new Grade(semester_id, rdr.GetString(1), rdr.GetString(2), rdr.GetFloat(3));
                grades.Add(grade);
            }

            con.Close();

            return grades;
        }
        public List<ISemester> Semesters()
        {
            string query = $"SELECT * FROM semesters";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<ISemester> semesters = new List<ISemester>();

            while (rdr.Read())
            {
                ISemester semester = new Semester(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));
                semesters.Add(semester);
            }

            con.Close();

            return semesters;
        }
        public List<ICourse> CoursesOfStudentBySemester(string username, string semester_id)
        {
            string table_name = "grades_" + semester_id;
            string query = $"SELECT course FROM {table_name} WHERE student = '{username}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<string> courses_id= new List<string>();

            while (rdr.Read())
            {
                courses_id.Add(rdr.GetString(0));
            }

            List<ICourse> courses = new List<ICourse>();

            foreach (var item in courses_id)
            {
                query = $"SELECT * FROM courses WHERE id = '{item}'";

                cmd = new SQLiteCommand(query, con);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ICourse course = new Course(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5));
                    courses.Add(course);
                }
            }

            con.Close();

            return courses;
        }
        public ICourse CourseById(string course_id)
        {
            string query = $"SELECT * FROM courses WHERE id = '{course_id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            ICourse course = null;

            while (rdr.Read())
            {
                course = new Course(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5));
            }

            con.Close();

            return course;
        }
        public List<ICourse> AllPassesCourses(string username)
        {
            List<ISemester> semesters = Semesters();
            string table_name = "", query = "";
            List<string> courses_id = new List<string>();
            List<ICourse> courses = new List<ICourse>();

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);
            SQLiteDataReader rdr = null;

            foreach (var item in semesters)
            {
                table_name = "grades_" + item.Id;
                query = $"SELECT course FROM {table_name} WHERE student = '{username}' AND status = 'passed'";

                cmd = new SQLiteCommand(query, con);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    courses_id.Add(rdr.GetString(0));
                }
            }

            foreach (var item in courses_id)
            {
                query = $"SELECT * FROM courses WHERE id = '{item}'";

                cmd = new SQLiteCommand(query, con);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ICourse course = new Course(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5));
                    courses.Add(course);
                }
            }

            con.Close();

            return courses;
        }
        public List<ICourse> CoursesBySemester(string semester_id)
        {
            string query = $"SELECT * FROM courses WHERE semester = '{semester_id}'";
            List<ICourse> courses = new List<ICourse>();
            ICourse course = null;

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                course = new Course(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5));
                courses.Add(course);
            }

            return courses;
        }
        public IInstructor InstructorById(string id)
        {
            string query = $"SELECT * FROM instructors WHERE id = '{id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            IInstructor instructor = null;

            while (rdr.Read())
            {
                instructor = new Instructor(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));
            }

            con.Close();

            return instructor;
        }
        public List<IInstructor> Instructors()
        {
            string query = $"SELECT * FROM instructors";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<IInstructor> instructors = new List<IInstructor>();

            while (rdr.Read())
            {
                IInstructor instructor = new Instructor(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));
                instructors.Add(instructor);
            }

            con.Close();

            return instructors;
        }
        public List<IField> Fields()
        {
            string query = $"SELECT * FROM fields";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<IField> fields = new List<IField>();

            while (rdr.Read())
            {
                IField field = new Field(rdr.GetString(0), rdr.GetString(1));
                fields.Add(field);
            }

            con.Close();

            return fields;
        }
        public List<ICourse> InstructorCoursesBySemester(string instructor_id, string semester_id)
        {
            string query = $"SELECT * FROM courses WHERE semester = '{semester_id}' AND instructor = '{instructor_id}'";
            List<ICourse> courses = new List<ICourse>();
            ICourse course = null;

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                course = new Course(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5));
                courses.Add(course);
            }

            return courses;
        }
        public List<IGrade> InstructorCourseByCourseId(string instructor_id, string course_id, string semester_id)
        {
            string table_name = "grades_" + semester_id;
            string query = $"SELECT * FROM {table_name} WHERE course = '{course_id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<IGrade> grades = new List<IGrade>();

            while (rdr.Read())
            {
                IGrade grade = new Grade(semester_id, rdr.GetString(1), rdr.GetString(2), rdr.GetFloat(3));
                grades.Add(grade);
            }

            con.Close();

            return grades;
        }
        public List<IStudent> Students()
        {
            string query = $"SELECT * FROM students";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<IStudent> students = new List<IStudent>();

            while (rdr.Read())
            {
                IStudent student = new Student(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5),
                rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), rdr.GetString(9));
                students.Add(student);
            }

            con.Close();

            return students;
        }
        public List<ICourse> Courses()
        {
            string query = $"SELECT * FROM courses";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<ICourse> courses = new List<ICourse>();

            while (rdr.Read())
            {
                ICourse course = new Course(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5));
                courses.Add(course);
            }

            con.Close();

            return courses;
        }
        public List<IStudent> StudentsInCourse(string course_id, string semester_id)
        {
            string table_name = "grades_" + semester_id;
            string query = $"SELECT student FROM {table_name} WHERE course = '{course_id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<IStudent> students = new List<IStudent>();

            while (rdr.Read())
            {
                students.Add(StudentById(rdr.GetString(0)));
            }

            return students;
        }
        //public List<IStudent> StudentsWithField(string field_name)
        //{
        //    string query = $"SELECT * FROM students WHERE field = '{field_name}'";

        //    var con = new SQLiteConnection(database_source);
        //    con.Open();

        //    var cmd = new SQLiteCommand(query, con);

        //    SQLiteDataReader rdr = cmd.ExecuteReader();

        //    List<IStudent> students = new List<IStudent>();

        //    while (rdr.Read())
        //    {
        //        students.Add(StudentById(rdr.GetString(0)));
        //    }

        //    return students;
        //}
        //public List<ICourse> CoursesWithField(string field_name);
        //public List<IInstructor> InstructorsWithField(string field_name);
        public IStudent StudentById(string id)
        {
            string query = $"SELECT * FROM students WHERE id = '{id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(query, con);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            IStudent student = null;

            while (rdr.Read())
            {
                student = new Student(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5),
                rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), rdr.GetString(9));
            }

            con.Close();

            return student;
        }


        /***************** DELETE *****************/
        public void DeleteAllUsers()
        {

        }
        public void DeleteUser(string username)
        {

        }
        public void DeleteCourse(string course_id)
        {
            string query = $"DELETE FROM courses WHERE id = '{course_id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void DeleteInstructor(string instructor_id)
        {
            string query = $"DELETE FROM instructors WHERE id = '{instructor_id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void DeleteStudent(string student_id)
        {
            string query = $"DELETE FROM courses WHERE id = '{student_id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void DeleteStudentFromCourse(string student_id, string course_id, string semester_id)
        {
            string table_name = "grades_" + semester_id;

            string query = $"DELETE FROM {table_name} WHERE student = '{student_id}' AND course = '{course_id}'";

            var con = new SQLiteConnection(database_source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }

        //public void CreateTablesIfNotExist()
        //{
        //    var con = new SQLiteConnection(database_source);
        //    con.Open();

        //    var cmd = new SQLiteCommand(con);

        //    string cmd_text = "CREATE TABLE IF NOT EXISTS users(username TEXT)";

        //    cmd.CommandText = cmd_text;
        //    cmd.ExecuteNonQuery();

        //    con.Close();
        //}


        // executing command for creating new table in declared database with given columns
        //public void CreateTableIfNotExists(string database_source, string table_name, Dictionary<string, string> columns_name_type)
        //{
        //    // declaring database source based on input
        //    if (database_source == "users")
        //    {
        //        //database_source = users_db;
        //    }
        //    else
        //    {
        //        //database_source = default_address + database_source;
        //    }

        //    // initializing the connection
        //    var con = new SQLiteConnection(database_source);
        //    con.Open();

        //    var cmd = new SQLiteCommand(con);

        //    // building up command
        //    string cmd_text = "CREATE TABLE IF NOT EXISTS" + table_name + "(";
        //    foreach (var item in columns_name_type)
        //    {
        //        cmd_text += $"{item.Key} {item.Value}, ";
        //    }
        //    //cmd_text -= ", ";
        //    cmd_text += ")";

        //    // executing command
        //    cmd.CommandText = cmd_text;
        //    cmd.ExecuteNonQuery();

        //    // closing connection
        //    con.Close();
        //}

        //public void InsertUserData(string username, string password, string role)
        //{
        //    //var con = new SQLiteConnection(users_db);
        //    //con.Open();

        //    //var cmd = new SQLiteCommand(con);

        //    //cmd.CommandText = $"INSERT INTO users(username, password, role) VALUES({username}, {password}, {role})";
        //    //cmd.ExecuteNonQuery();

        //    //con.Close();
        //}
        /*
        public void DeleteData()
        {
            var con = new SQLiteConnection(source);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM akbars WHERE name = 'akbar'";
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public List<string> ReadData()
        {
            var con = new SQLiteConnection(source);
            con.Open();

            string stm = "SELECT * FROM cars";

            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<string> list = new List<string>();

            while (rdr.Read())
            {
                // column indexed from 0
                list.Add(rdr.GetString(1));
            }

            con.Close();

            return list;
        }
        */
    }
}
