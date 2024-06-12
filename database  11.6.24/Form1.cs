using Microsoft.VisualBasic;

namespace database__11._6._24
{
    public partial class Form1 : Form
    {
        
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            listBox0.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            LoadStudent();

        }
        private void LoadStudent()
        {
            txtStudentID.Text = Database.TheStudents.students[i].StudentId.ToString();
            txtFirstName.Text = Database.TheStudents.students[i].FirstName;
            txtSecondName.Text = Database.TheStudents.students[i].SecondName;
            txtDoB.Text = Database.TheStudents.students[i].DoB.ToString().Substring(0,10);
            
            listBox0.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();


            var testResults = from tr in Database.Results.results
                              join t in Database.Tests.tests on tr.TestId equals t.TestId
                              where tr.StudentId == Database.TheStudents.students[i].StudentId
                              select new
                              {
                                  TestName = t.TestName,
                                  Score = tr.Score,
                                  MaxScore = t.MaxMark,
                                  DateTaken = tr.DateTaken,
                                  percentScore = (double)tr.Score / (double)t.MaxMark * 100
                              };
            foreach (var r in testResults)
            {
                listBox0.Items.Add(r.TestName);
                listBox1.Items.Add(r.Score.ToString());
                listBox2.Items.Add(r.DateTaken.ToString().Substring(0,10));
                listBox3.Items.Add(r.MaxScore.ToString());
            }
            double AverageTestScore = testResults.Average(t => t.percentScore);
            txtAvg.Text = AverageTestScore.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                LoadStudent();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < Database.TheStudents.students.Count - 1)
            {
                i++;
                LoadStudent();
            }
        }

        
    }
}
