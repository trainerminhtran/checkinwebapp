using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class GiftInfor
    {
        public GiftInfor()
        {
            GiftCourseRecord = new HashSet<GiftCourseRecord>();
        }

        public int Id { get; set; }
        public long ImageId { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Datetime { get; set; }
        public bool? Status { get; set; }

        public virtual ImageInfor Image { get; set; }
        public virtual ICollection<GiftCourseRecord> GiftCourseRecord { get; set; }
    }
}
