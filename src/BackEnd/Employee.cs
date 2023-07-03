using FinalProjectUltimate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.BackEnd
{
    // there might be other types of employees
    internal class Employee : IUser
    {
        // properties concerning with object being a user
        private string username;
        private string password;
        private string role = "employee";

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
