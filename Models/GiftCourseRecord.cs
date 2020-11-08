using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class GiftCourseRecord
    {
        public long Id { get; set; }
        public int? CourseId { get; set; }
        public int? GiftInforId { get; set; }
        public int? GiftTypeId { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual CourseInfor Course { get; set; }
        public virtual GiftInfor GiftInfor { get; set; }
        public virtual GiftType GiftType { get; set; }
    }
}
