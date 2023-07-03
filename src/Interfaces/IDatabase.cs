using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IDatabase : IDBCreate, IDBDelete, IDBSearch, IDBInsert, IDBUpdate
    {
        /***************** CREATE *****************/
        //void CreateTablesIfNotExists();
        //void CreateGradesForSemester(string semester_id);

        /***************** DELETE *****************/

        /***************** SEARCH *****************/

        /***************** INSERT *****************/
        //void InsertUser(string username, string password, string role);
        //void InsertStudent();
        //void InsertInstructor();
        //void InsertEmployee();
        //void InsertSemester();
        //void InsertCourse();
        //void InsertGrade(string semester_id);

        /***************** UPDATE *****************/

    }
}
