using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProjectUltimate.HandlingIntefaces;
using FinalProjectUltimate.Interfaces;

namespace FinalProjectUltimate
{
    internal interface IHandler : IHandleLogIn, IHandleAddStaff, IHandleStudentRequest, IHandleAddSemCourse, IHandleInstructorRequest, IHandleEmployeeRequest
    {
        List<IField> Fields();
    }
}
