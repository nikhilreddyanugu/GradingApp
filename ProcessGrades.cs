using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingApp
{
    internal class ProcessGrades : IProcessGrades
    {
        public List<Student> STList { get; set; } = new List<Student>();
        public void ProcessAndWriteGrades(string outFileName)
        {
            StreamWriter sw = new StreamWriter(outFileName);
            try
            {
                STList.Sort();
                foreach (Student st in STList)
                {
                    string grade = st.ComputeGrade(); // polymorphism, correct ComputeGrade
                                                      // will be called depending upon the type of student in s
                    sw.WriteLine(st.ID + "\t" + grade);
                }
                sw.Close();
            }
            catch
            {
                throw; // if error, send error back to the calling code
            }

            finally // always triggered even if there is no error
            {
                sw.Close();

            }



        }
        public void ReadStudentData(string inputFileName)
        { // will read students into the STList 
            try
            {
                STList.Clear(); // clear the list of students
                StreamReader sr = new StreamReader(inputFileName);
                string sline = sr.ReadLine();
                while (sline != null)
                {
                    Student st = null; // base class reference
                    string[] parts = sline.Split(new char[] { '\t' });
                    if (parts.Length == 6) // undergrad student
                    {
                        if (parts[3].ToUpper() == "UNDERGRAD")
                        {
                            st = new UnderGradStudent(int.Parse(parts[0]), parts[1],
                            parts[2], int.Parse(parts[4]), int.Parse(parts[5]));
                        }
                    }
                    if (parts.Length == 7) // grad student
                    {
                        if (parts[3].ToUpper() == "GRADUATE")
                        {
                            st = new GradStudent(int.Parse(parts[0]), parts[1],
                            parts[2], int.Parse(parts[4]), int.Parse(parts[5]), parts[6]);
                        }
                    }
                    if (parts.Length == 8) // Phd student
                    {
                        if (parts[3].ToUpper() == "PHDCPSC")
                        {
                            st = new PhdStudent(int.Parse(parts[0]), parts[1],
                            parts[2], int.Parse(parts[4]), int.Parse(parts[5]), parts[6], parts[7]);
                        }
                    }
                    if (st != null)
                        STList.Add(st); // add student to the list
                    sline = sr.ReadLine(); // read next line
                }
            }
            catch
            {
                throw; // if error, send error back to the calling code
            }
        }
    }
}
