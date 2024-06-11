using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace database__11._6._24
{
    internal class Student
    {
        public int? StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public DateTime? DoB { get; set; }

        public Student(DataRow dr)
        {
            StudentId = int.Parse(dr["StudentId"].ToString());
            FirstName = dr["FirstName"].ToString();
            SecondName = dr["SecondName"].ToString();
            DoB = DateTime.Parse(dr["DoB"].ToString());
        }
    }
}
