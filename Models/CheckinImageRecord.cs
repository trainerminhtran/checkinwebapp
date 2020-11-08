using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class CheckinImageRecord
    {
        public long Id { get; set; }
        public long CheckinId { get; set; }
        public long? ImageId { get; set; }

        public virtual CheckinInfor Checkin { get; set; }
        public virtual ImageInfor Image { get; set; }
    }
}
