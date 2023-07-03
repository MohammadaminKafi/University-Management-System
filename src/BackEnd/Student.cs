using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// other than System namespaces
using FinalProjectUltimate.Interfaces;

namespace FinalProjectUltimate.BackEnd
{
    // there might be other types of students
    internal class Student : IUser, IStudent
    {
        // properties concerning with object being a user
        private string username;
        private string password;
        string role = "student";

        public string Username { get => username; set { } }
        public string Password { get => password; set { } }
        public string Role { get => role; }
        

        // properties concerning with object being a student
        private string field; // username is used for any type of interaction between classes
        private string first_name;
        private string last_name;
        private List<ICourse> courses;

        public string Field { get => field; set { } }
        public string First_name { get => first_name; set { } }
        public string Last_name { get => last_name; set { } }
        //public List<ICourse> Courses { get => courses; set { } }

        

        // other properties
        private string email;
        private string phone_number;
        private string national_number;
        private string birth_date;
        private string city;
        private string address;
        private double overall_average;
        private int total_passed_units;

        public string Email { get => email; set { } }
        public string Phone_number { get => phone_number; set { } }
        public string National_number { get => national_number; set { } }
        public string Birth_date { get => birth_date; set { } }
        public string City { get => city; set { } }
        public string Address { get => address; set { } }
        public double Overall_average { get => overall_average; set => overall_average = value; }
        public int Total_passed_units { get => total_passed_units; set => total_passed_units = value; }


        // default constructor
        public Student() { }

        // parameterized constructors
        public Student(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Student(string username, 
            string first_name,
            string last_name,
            string field)
        {
            Username = username;
            First_name = first_name;
            Last_name = last_name;
            Field = field;
        }

        public Student(string username,
            string first_name, string last_name, string field, string email, string phone_number, string national_number, string birth_date, string city, string address)
        {
            this.username = username;
            this.field = field;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.national_number = national_number;
            this.birth_date = birth_date;
            this.city = city;
            this.address = address;
        }
    }
}
