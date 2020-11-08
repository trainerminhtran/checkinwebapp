using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class CourseInfor
    {
        public CourseInfor()
        {
            ContentCourseRecord = new HashSet<ContentCourseRecord>();
            CourseTestRecord = new HashSet<CourseTestRecord>();
            GiftCourseRecord = new HashSet<GiftCourseRecord>();
            RoomInfor = new HashSet<RoomInfor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Datetime { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<ContentCourseRecord> ContentCourseRecord { get; set; }
        public virtual ICollection<CourseTestRecord> CourseTestRecord { get; set; }
        public virtual ICollection<GiftCourseRecord> GiftCourseRecord { get; set; }
        public virtual ICollection<RoomInfor> RoomInfor { get; set; }
    }
}
