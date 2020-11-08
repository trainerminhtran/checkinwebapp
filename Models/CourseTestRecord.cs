using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class CourseTestRecord
    {
        public long Id { get; set; }
        public int TestId { get; set; }
        public int CourseId { get; set; }
        public bool? Status { get; set; }

        public virtual CourseInfor Course { get; set; }
        public virtual TestInfor Test { get; set; }
    }
}
