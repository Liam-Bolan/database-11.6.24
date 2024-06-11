using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database__11._6._24
{
    internal class TestResult
    {
        public int? StudentId { get; set; }
        public int? TestId { get; set; }
        public int? Score { get; set; }
        public DateTime? DateTaken { get; set; }

        public TestResult(DataRow dr)
        {
            StudentId = int.Parse(dr["StudentId"].ToString());
            TestId = int.Parse(dr["TestId"].ToString());
            Score = int.Parse(dr["Score"].ToString());
            DateTaken = DateTime.Parse(dr["DateTaken"].ToString());

        }
    }
}
