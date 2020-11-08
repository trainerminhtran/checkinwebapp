using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class ContentInfor
    {
        public ContentInfor()
        {
            ContentCourseRecord = new HashSet<ContentCourseRecord>();
            ContentModelRecord = new HashSet<ContentModelRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FileUrl { get; set; }
        public DateTime? Datetime { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<ContentCourseRecord> ContentCourseRecord { get; set; }
        public virtual ICollection<ContentModelRecord> ContentModelRecord { get; set; }
    }
}
