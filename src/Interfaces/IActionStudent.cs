using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IActionStudent
    {
        double CalculateAverage(string semester_id);
        void ClaculateOverallAverage();
        int CalculateUnits(string semester_id);
        int CalculateTotalPassedUnits();
    }
}
