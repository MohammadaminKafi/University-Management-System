using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.HandlingIntefaces
{
    internal interface IHandleAddStaff
    {
        string AddStudent(string username, string password,
            string first_name, string last_name, string field,
            string email, string phone_number, string city, string address,
            string national_number, string birth_date);
        string AddInstructor(string username, string password,
            string first_name, string last_name, string field,
            string email);
        string AddEmployee(string username, string password,
            string first_name, string last_name);
    }
}
