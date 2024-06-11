using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database__11._6._24
{
    internal class Test
    {
        public int? TestId { get; set; }
        public string? TestName { get; set; }
        public int? MaxMark { get; set; }

        public Test(DataRow dr)
        {
            TestId = int.Parse(dr["TestId"].ToString());
            TestName = dr["TestName"].ToString();
            MaxMark = int.Parse(dr["MaxMark"].ToString());
        }
    }
}
