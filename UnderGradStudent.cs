﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingApp
{
    internal class UnderGradStudent:Student
    {
        public UnderGradStudent(int id, string fname, string lname, int test1, int test2) : base(id, fname, lname, test1, test2)
        {  // delegate initialization to base class constructor
           // ID, FirstName, LastName, Test1, Test2 are inherited from Student
        }
        public override string ComputeGrade()
        {
            double avg = 0.4 * Test1 + 0.6 * Test2;
            string grade = "";
            if (avg > 90)
                grade = "A";
            else if (avg > 85)
                grade = "A-";
            else if (avg > 80)
                grade = "B+";
            else if (avg > 70)
                grade = "B";
            else
                grade = "C";
            return grade;
        }
    }
}
