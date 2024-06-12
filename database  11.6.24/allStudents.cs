using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace database__11._6._24
{
    class allStudents
    {
        public List<Student> students { get; set; }
        public allStudents()
        {
            SqlConnection DBConnection = new SqlConnection(Database.Connection);
            string getStudentsSQL = "select * from student";
            DBConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(getStudentsSQL, DBConnection);
            DataTable Results = new DataTable();
            da.Fill(Results);
            DBConnection.Close();
            students = new List<Student>();
            foreach(DataRow dr in Results.Rows)
            {
                Student s = new Student(dr);
                students.Add(s);
            }
        }
    }
    class allTests
    {
        public List<Test> tests { get; set; }
        public allTests()
        {
            SqlConnection DBConnection = new SqlConnection(Database.Connection);
            string getStudentsSQL = "select * from Test";
            DBConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(getStudentsSQL, DBConnection);
            DataTable Results = new DataTable();
            da.Fill(Results);
            DBConnection.Close();
            tests = new List<Test>();
            foreach (DataRow dr in Results.Rows)
            {
                Test s = new Test(dr);
                tests.Add(s);
            }
        }
    }
    class allResults
    {
        public List<TestResult> results { get; set; }
        public allResults()
        {
            SqlConnection DBConnection = new SqlConnection(Database.Connection);
            string getStudentsSQL = "select * from TestResults";
            DBConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(getStudentsSQL, DBConnection);
            DataTable Results = new DataTable();
            da.Fill(Results);
            DBConnection.Close();
            results = new List<TestResult>();
            foreach (DataRow dr in Results.Rows)
            {
                TestResult s = new TestResult(dr);
                results.Add(s);
            }
        }

    }
    class Database
    {
        public static string Connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\Visual studio stuff\database  11.6.24\database  11.6.24\StudentTests1.mdf"";Integrated Security=True";
        public static allStudents TheStudents = new allStudents();
        public static allResults Results = new allResults();
        public static allTests Tests = new allTests();

    }

        
}
