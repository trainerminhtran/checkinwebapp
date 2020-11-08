using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class GiftType
    {
        public GiftType()
        {
            GiftCourseRecord = new HashSet<GiftCourseRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GiftCourseRecord> GiftCourseRecord { get; set; }
    }
}
