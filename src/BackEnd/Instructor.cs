using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// other than System namespaces
using FinalProjectUltimate.Interfaces;

namespace FinalProjectUltimate.BackEnd
{
    internal class Instructor : IUser, IInstructor
    {
        // properties concerning with object being a user
        private string username; // username is used for any type of interaction between classes
        private string password;
        private string role = "professor";

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role;}
        

        // properties concerning with object being instructor
        private string first_name;
        private string last_name;
        private string field;
        private List<ICourse> courses;
        private string email;
        

        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Field { get => field; set => field = value; }
        public List<ICourse> Courses { get => courses; set => courses = value; }
        public string Email { get => email; set => email = value; }

        public Instructor() { }

        public Instructor(string username, string first_name, string last_name, string field)
        {
            this.username = username;
            this.first_name = first_name;
            this.last_name = last_name;
            this.field = field;
        }
    }
}
