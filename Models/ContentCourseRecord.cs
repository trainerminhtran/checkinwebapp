using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class ContentCourseRecord
    {
        public long Id { get; set; }
        public int? CourseId { get; set; }
        public int? ContentId { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual ContentInfor Content { get; set; }
        public virtual CourseInfor Course { get; set; }
    }
}
