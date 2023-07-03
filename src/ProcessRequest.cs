using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProjectUltimate.BackEnd;
using FinalProjectUltimate.Additionals;
using FinalProjectUltimate.Interfaces;


namespace FinalProjectUltimate
{
    internal class ProcessRequest : IHandler
    {
        IHash hash= new SHA256();
        IDatabase db = new SQLiteManager();
        IConvertToExcel convert_to_excel = new ConvertToExcel();
        IConvertToPDF convert_to_pdf = new ConvertToPDF();

        // parameterized constructor that loads data
        public ProcessRequest() { }

        

        // method for log in, sign up, forgot password
        public string LogIn(string username, string password) // log in
        {
            password = hash.ComputeHash(password);
            // username availablity in data
            if (!db.DoesUserExists(username))
            {
                return "User not found!";
            }
            else if (db.PasswordByUsername(username) != password)
            {
                return "Incorrect password!";
            }
            else
            {
                return "Succesful log in!";
            }
        }
        public string Role(string username)
        {
            return db.RoleByUsername(username);
        }
        public string SignUp(string username, string password) // sign up (not adding a student or other roles to system)
        {
            password = hash.ComputeHash(password);
            if (db.DoesUserExists(username))
            {
                return "Username already exists!";
            }
            else
            {
                db.InsertUser(username, password, "None");
                return "Added to system!";
            }
        }
        public string ForgotPassword() // forgot password
        {
            return "";
        }


        // methods for adding different objects
        public string AddStudent(string username, string password,
            string first_name, string last_name, string field,
            string email = "", string phone_number = "", string city = "", string address = "",
            string national_number = "", string birth_date = "") // Add student
        {
            password = hash.ComputeHash(password);
            if (db.DoesUserExists(username))
            {
                return "Username already exists";
            }
            else
            {
                db.InsertUser(username, password, "student");
                db.InsertStudent(username, first_name, last_name, email, phone_number, birth_date, city, address);
                return "Student added to system!";
            }
        }
        public string AddInstructor(string username, string password,
            string first_name, string last_name, string field,
            string email = "") // Add instructor
        {
            password = hash.ComputeHash(password);
            if (db.DoesUserExists(username))
            {
                return "Username already exists";
            }
            else
            {
                db.InsertUser(username, password, "instructor");
                db.InsertInstructor(username, first_name, last_name, field, email);
                return "Instructor added to system!";
            }
        }
        public string AddEmployee(string username, string password, 
            string first_name, string last_name) // Add employee
        {
            password = hash.ComputeHash(password);
            if (db.DoesUserExists(username))
            {
                return "Username already exists";
            }
            else
            {
                db.InsertUser(username, password, "employee");
                db.InsertEmployee(username, first_name, last_name);
                return "Employee added to system!";
            }
        }
        public string AddSemester() // Add Semester
        {
            return "";
        }
        public string AddCourse() // Add course
        {
            return "";
        }


        // methods for handling student requests
        public IStudent StudentGeneralInformation(string username)
        {
            IStudent student = db.SearchStudent(username);
            IActionStudent action = new ActionStudent(student);
            action.ClaculateOverallAverage();
            action.CalculateTotalPassedUnits();
            return student;
        }
        public string StudentChangeInformation(string username, string email, string phone_number, string birth_date, string city, string address)
        {
            db.UpdateStudentAddress(username, address);
            db.UpdateStudentBirthDate(username, birth_date);
            db.UpdateStudentCity(username, city);
            db.UpdateStudentEmail(username, email);
            db.UpdateStudentPhoneNumber(username, phone_number);
            return "Done!";
        }
        public string StudentRegistration(string username, string course_id, string current_semester_id, string previous_semester_id)
        {
            IStudent student = db.SearchStudent(username);
            IActionStudent action = new ActionStudent(student);
            double average = action.CalculateAverage(previous_semester_id);
            int units = action.CalculateUnits(current_semester_id);
            int course_unit = db.CourseById(course_id).Unit;

            foreach (var grade in StudentGrades(username, current_semester_id))
            {
                if (course_id == grade.Course_id)
                {
                    return "Course already taken";
                }
            }

            if (average > 17)
            {
                if (units <= 24 - course_unit)
                {
                    db.InsertGrade(current_semester_id, course_id, username);
                    return "Course added!";
                }
                else
                {
                    return "Too many courses!";
                }
            }
            else if (average > 12)
            {
                if (units <= 20 - course_unit)
                {
                    db.InsertGrade(current_semester_id, course_id, username);
                    return "Course added!";
                }
                else
                {
                    return "Too many courses!";
                }
            }
            else
            {
                if (units <= 12 - course_unit)
                {
                    db.InsertGrade(current_semester_id, course_id, username);
                    return "Course added!";
                }
                else
                {
                    return "Too many courses!";
                }
            }
        }
        public string UserChangePassword(string username, string new_password)
        {
            new_password = hash.ComputeHash(new_password);
            db.UpdatePassword(username, new_password);
            return "Password succesfully changed";
        }
        public List<IGrade> StudentGrades(string username, string semester_id)
        {
            return db.GradesOfStudentBySemester(username, semester_id);
        }
        public List<ICourse> courses(string semester)
        {
            return db.CoursesBySemester(semester);
        }
        public string LatestSemester()
        {
            List<ISemester> semesters = db.Semesters();
            if (semesters.Count < 1)
            {
                return "20231";
            }
            return semesters[semesters.Count - 1].Id;
        }
        public string OneToLatestSemester()
        {
            List<ISemester> semesters = db.Semesters();
            if (semesters.Count < 2)
            {
                return "20231";
            }
            return semesters[semesters.Count - 2].Id;
        }

        // methods for adding course, semester and field
        public string AddCourse(string course_id, string course_name, string instructor_id, int unit, string field, string semester_id)
        {
            if (db.CourseById(course_id) != null)
            {
                return "Course already exits";
            }
            else if (db.InstructorById(instructor_id).Field != field)
            {
                return "Instructor field not match";
            }
            else
            {
                db.InsertCourse(course_id, semester_id, instructor_id, unit, field, course_name);
                return "Course added!";
            }
        }
        public string AddSemester(string id, string start, string end, string start_reg, string end_reg)
        {
            foreach (var item in db.Semesters())
            {
                if (item.Id == id)
                {
                    return "Semester already exists!";
                }
            }
            db.CreateGradesForSemester(id);
            db.InsertSemester(id, start, end, start_reg, end_reg);
            return "Semester added!";
        }
        public string AddField(string id, string field)
        {
            foreach (var item in db.Fields())
            {
                if (item.Id == id)
                {
                    return "Id already exists";
                }
                if (item.Name == field)
                {
                    return "Name already exists";
                }
            }
            db.InsertField(id, field);
            return "Field added";
        }
        public List<IInstructor> Instructors()
        {
            return db.Instructors();
        }

        // methods for handling instructor request
        public IInstructor InstructorGeneralInformation(string username)
        {
            return db.InstructorById(username);
        }
        public string InstructorChangeInformation(string username, string email)
        {
            db.UpdateInstructorEmail(username, email);
            return "Done!";
        }
        public List<ICourse> InstructorCoursesInSemester(string username, string semester_id)
        {
            return db.InstructorCoursesBySemester(username, semester_id);
        }
        public List<IGrade> InstructorCoursesByStudentList(string username, string course_id, string semester_id)
        {
            return db.InstructorCourseByCourseId(semester_id, username, course_id);
        }
        public string SetFinalScore(string instructor_id, string student_id, string course_id, string semester_id, double grade)
        {
            bool flag = false;
            foreach (var item in db.CoursesOfStudentBySemester(student_id, semester_id))
            {
                if (item.Id == course_id)
                {
                    flag= true;
                }
            }
            if (!flag)
            {
                return "Student is not in course!";
            }

            db.UpdateGrade(semester_id, course_id, student_id, grade);
            return "Grade has been set!";
        }
        public List<ISemester> Semesters()
        {
            return db.Semesters();
        }

        // methods for handling employee requests
        public string DeleteCourse(string course_id) 
        { 
            db.DeleteCourse(course_id);
            return "Done";
        }
        public string UpdateCourse(string course_id, string course_name, string instructor_id, int unit, string field)
        {
            db.UpdateCourseName(course_id, course_name);
            db.UpdateCourseInstructor(course_id, instructor_id);
            db.UpdateCourseUnit(course_id, unit);
            db.UpdateCourseField(course_id, field);
            return "Done";
        }
        public List<IStudent> Students()
        {
            return db.Students();
        }
        public string UpdateStudent(string id, string first_name, string last_name, string field, string phone_number, string national_number)
        {
            db.UpdateStudentField(id, field);
            db.UpdateStudentPhoneNumber(id, phone_number);
            return "Done";
        }
        public string DeleteStudent(string id)
        {
            db.DeleteStudent(id);
            return "Done";
        }
        public string UpdateInstructor(string id, string first_name, string last_name, string field, string email)
        {
            db.UpdateInstructorField(id, field);
            db.UpdateInstructorEmail(id, email);
            return "Done";
        }
        public string DeleteInstructor(string id)
        {
            try
            {
                db.DeleteInstructor(id);
                return "Done";
            }
            catch (Exception)
            {
                return "Error occurred";
            }
                
        }
        public string AddStudentToCourse(string student_id, string course_id)
        {
            return StudentRegistration(student_id, course_id, LatestSemester(), OneToLatestSemester());
        }
        public string RemoveStudentFromCourse(string student_id, string course_id)
        {
            ICourse course = db.CourseById(course_id);
            db.DeleteStudentFromCourse(student_id, course_id, course.Semester_id);
            return "Done";
        }
        public string AddInstructorToCourse(string instructor_id, string course_id)
        {
            if (db.CourseById(course_id).Field != db.InstructorById(instructor_id).Field)
            {
                return "Field not match";
            }
            else
            {
                db.UpdateCourseInstructor(instructor_id, course_id);
                return "Done";
            }
        }
        public string RemoveInstructorFromCourse(string instructor_id, string course_id)
        {
            db.UpdateCourseInstructor(course_id, "");
            return "Done";
        }
        //public List<IReportI> EmployeeReportI()
        //{
        //    List<IReportI> report= new List<IReportI>();
        //    List<ICourse> courses = db.Courses();
        //    foreach (var item in courses)
        //    {
        //        ReportI rep = new ReportI(item.Id, item.Name, db.InstructorById(item.Instructor_id).Last_name, CalculateNumberOfStudentsInCourse(item.Id, item.Semester_id));
        //        report.Add(rep);
        //    }
        //    //convert_to_excel.ListToExcel(report, "ReportI");
        //    return report;
        //}
        //private int CalculateNumberOfStudentsInCourse(string course_id, string semester_id)
        //{
        //    List<IStudent> students = 
        //}
        //public List<IReportII> EmployeeReportII();
        public List<IField> Fields()
        {
            return db.Fields();
        }
    }
}
