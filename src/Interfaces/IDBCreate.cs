using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IDBCreate
    {
        void CreateTablesIfNotExists();
        void CreateGradesForSemester(string semester_id);
    }
}
