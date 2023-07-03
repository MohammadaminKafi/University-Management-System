using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.HandlingIntefaces
{
    internal interface IHandleLogIn
    {
        string LogIn(string username, string password);
        string SignUp(string username, string password);
        //string LogOut(string username, string password);
        string ForgotPassword();
        string Role(string username);
    }
}
