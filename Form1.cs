namespace GradingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessGrad_Click(object sender, EventArgs e)
        {
            try
            {
                string inputFile = "C:\\UB sem 1\\OOPS\\StudentsData.txt";
                string outputFile = "C:\\UB sem 1\\OOPS\\StudentsGrades.txt";
                ProcessGrades pg = new ProcessGrades();
                pg.ReadStudentData(inputFile);
                pg.ProcessAndWriteGrades(outputFile);
                MessageBox.Show("Grades processed, examine file " + outputFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}