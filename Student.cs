using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingApp
{
    abstract class Student:IComparable<Student>
    {
        public Student(int id, string fname, string lname, int test1, int test2)
        { // constructor
            this.ID = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Test1 = test1;
            this.Test2 = test2;
        }
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Test1 { get; set; }
        public int Test2 { get; set; }
        public int CompareTo(Student? other)
        {
            int ret = 0;
            if (other != null)
                return -
               1 * GetGradePoints(this.ComputeGrade()).CompareTo(GetGradePoints(other.ComputeGrade()));
            return ret;
        }
        double GetGradePoints(string grade)
        {
            double points = 0;
            switch (grade)
            {
                case "A":
                    points = 4.0;
                    break;
                case "A-":
                    points = 3.7;
                    break;
                case "B+":
                    points = 3.3;
                    break;
                case "B":
                    points = 3.0;
                    break;
                case "B-":
                    points = 2.7;
                    break;
                case "C+":
                    points = 2.3;
                    break;
                case "C":
                    points = 2.0;
                    break;
                default:
                    points = 1.0;
                    break;
            }
            return points;
        }


        public abstract string ComputeGrade();
    }
}
