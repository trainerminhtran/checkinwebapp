using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class ImageInfor
    {
        public ImageInfor()
        {
            CheckinImageRecord = new HashSet<CheckinImageRecord>();
            GiftInfor = new HashSet<GiftInfor>();
        }

        public long Id { get; set; }
        public string UrlThumbnail { get; set; }
        public string UrlFullsize { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual ICollection<CheckinImageRecord> CheckinImageRecord { get; set; }
        public virtual ICollection<GiftInfor> GiftInfor { get; set; }
    }
}
