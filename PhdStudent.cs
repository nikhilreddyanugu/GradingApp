using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingApp
{
    internal class PhdStudent:Student
    {
        public PhdStudent(int id, string fname, string lname, int test1, int test2, string dissertation, string advisor) : base(id, fname, lname, test1, test2)
        { // delegate initialization to base class constructor for first 5 fields
            this.Dissertation = dissertation; // initialization of extra field
            this.Advisor = advisor; // initialization of extra field
        }
        // ID, FirstName, LastName, Test1, Test2 are inherited from Student
        public string Dissertation { get; set; } // added field in PhdStudent class
        public string Advisor { get; set; } // added extra field in PhdStudent class
        public override string ComputeGrade()
        {
            double avg = 0.4 * Test1 + 0.6 * Test2;
            string grade = "";
            if (avg > 95) // more than 95 is an A for a PhdStudent
                grade = "A";
            else if (avg > 90)
                grade = "A-";
            else if (avg > 87)
                grade = "B+";
            else if (avg > 80)
                grade = "B";
            else
                grade = "C";
            return grade;
        }

    }
}
