using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingApp
{
    internal interface IProcessGrades
    {
        void ReadStudentData(string inputFileName);
        void ProcessAndWriteGrades(string outFileName);
    }
}
