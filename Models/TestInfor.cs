using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class TestInfor
    {
        public TestInfor()
        {
            CourseTestRecord = new HashSet<CourseTestRecord>();
            TestQuestionRecord = new HashSet<TestQuestionRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Score { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual ICollection<CourseTestRecord> CourseTestRecord { get; set; }
        public virtual ICollection<TestQuestionRecord> TestQuestionRecord { get; set; }
    }
}
